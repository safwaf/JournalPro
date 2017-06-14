using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JournalPro
{
    public partial class Form1 : Form
    {
        List<Project> ProjectList = new List<Project>();

        public Form1()
        {
            InitializeComponent();
            StreamReader sr = File.OpenText("default.jjf");
            if (!FullLoad(sr)) MessageBox.Show("The file you are trying to load from is corrupt or is not a valid JournalPro journal file", "You done goofed son!");
            sr.Dispose();
        }

        private void SaveSignature(StreamWriter sw)
        {
            sw.WriteLine("~@#");
        }

        private void SaveProject(StreamWriter sw,Project p)
        {
            sw.WriteLine("#" + p.number + "@" + p.name + "~");
        }

        private void SaveEntry(StreamWriter sw, Entry e)
        {
            sw.WriteLine("#" + e.project.number + "#" + e.number + "@" + e.text + "~");
        }

        private void FullSave(StreamWriter sw)
        {
            //save format is as follows:
            //the file begins with the line ~@#. this signifies that it is a valid save file for JournalPro
            //next is the projects list. each project is on a line beginning with #n where n is the project number. numbering begins at 0
            // this number is followed by @ and then the name of the project and a ~
            //after all projects are listed, there will be another ~@# 
            //now, each entry will be listed
            //entries begin with #n signifying the project they belong to and then a #n signifying the number of the entry.
            //this is followed by an @, the text of the entry, and then a ~
            //the end of the file is signified once again by ~@#

            //we will not actually use lines, they are unecessary
            SaveSignature(sw);
            foreach (Project p in ProjectList)
            {
                SaveProject(sw, p);
            }
            SaveSignature(sw);
            foreach (Project p in ProjectList)
            {
                foreach(Entry e in p.entryList)
                {
                    SaveEntry(sw, e);
                }
            }
            SaveSignature(sw);
        }

        private bool LoadSignature(StreamReader sr)
        {
            //this function is used to check for the JournalPro file signature
            //if it ever returns false, it means that the file is corrupted or not a valid JournalPro file
            //as such, it should only be checked when we know that it should be there
            //We can peek for the Tilde when looking for the center signature

            if (sr.ReadLine()=="~@#")
                return true;
            else
                return false;
        }

        private bool LoadEntry(StreamReader sr)
        {
            int eNum = 0;
            int pNum = 0;
            string text = "";

            if (!((char)sr.Read() == '#')) return false;
            while ((char)sr.Peek() != '#')
            {
                pNum = pNum * 10;
                pNum = pNum + (int)sr.Read()-48;
            }
            sr.Read();
            while ((char)sr.Peek() != '@')
            {
                eNum = eNum * 10;
                eNum = eNum + (int)sr.Read()-48;
            }
            sr.Read();
            while ((char)sr.Peek() != '~')
            {
                text = text + (char)sr.Read();
            }
            sr.ReadLine();
            ProjectList[pNum].entryList.Add(new Entry(eNum, ProjectList[pNum], text));
            return true;
        }

        private bool LoadProject(StreamReader sr)
        {
            int pnum=0;
            string pname = "";
            if (!((char)sr.Read() == '#')) return false;
            while ((char)sr.Peek()!='@')
            {
                pnum = pnum * 10;
                pnum = pnum + (int)sr.Read()-48;
            }
            sr.Read();
            while ((char)sr.Peek() != '~')
            {
                pname = pname + (char)sr.Read();
            }
            sr.ReadLine();
            ProjectList.Add(new Project(pnum, pname));

            return true;
        }

        private bool FullLoad(StreamReader sr)
        {
            //if at any point a load returns false, it means the file is corrupted or improperly formatted
            //as such, if FullLoad returns a false we should display an error message
            if (!LoadSignature(sr)) return false;
            while ((char)sr.Peek() == '#')
            {
                if (!LoadProject(sr)) return false;
            }
            if (!LoadSignature(sr)) return false;
            while ((char)sr.Peek() == '#')
            {
                if (!LoadEntry(sr)) return false;
            }
            if (!LoadSignature(sr)) return false;
                return true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            File.Delete("default.jjf");
            StreamWriter sw = File.AppendText("default.jjf");
            FullSave(sw);
            sw.Dispose();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            ProjectList.Clear();
        }

        private void button_AddProject_Click(object sender, EventArgs e)
        {
            ProjectList.Add(new Project(ProjectList.Count, textbox_ProjectName.Text));
        }

        private void button_PopulateProjectList_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach (Project p in ProjectList)
            {
                listView1.Items.Add(p.name);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = ProjectList.Count - 1;
            NewEntryProject_textbox.Text = ProjectList[(int)numericUpDown1.Value].name;
        }

        private void button_addEntry_Click(object sender, EventArgs e)
        {
            ProjectList[(int)numericUpDown1.Value].entryList.Add(new Entry(ProjectList[(int)numericUpDown1.Value].entryList.Count, ProjectList[(int)numericUpDown1.Value], textBox1.Text));
        }
    }
}
