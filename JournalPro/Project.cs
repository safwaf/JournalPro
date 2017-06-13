using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalPro
{
    class Project
    {
        public int number;
        public string name;
        public List<Entry> entryList = new List<Entry>();   //may be more appropriate to use a list structure

        public Project(int pNumber,string pName)
        {
            number = pNumber;
            name = pName;
        }

        public Project()
        {

        }
    }
}
