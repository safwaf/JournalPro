using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalPro
{
    class Entry
    {
        public int number;
        public Project project;
        public string text;

        public Entry(int EntryNumber, Project EntryProject, string EntryText)
        {
            number = EntryNumber;
            project = EntryProject;
            text = EntryText;
        }
        
        public Entry()
        {

        }

    }
}
