using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication5
{
    class Class1
    {
        public string s;
        public string гост;
        public string название;
        public int год;
        public int id;
        public List<string> тег;
        public Class1(int id,string гост, string название, int год, List<string> тег)
        {
            this.гост = гост;
            this.название = название;
            this.год = год;
            this.id = id;
            this.тег = тег;
        }
        public string X
        {
            get { return гост; }
            set { гост = value; }
        }
        public string K
        {
            get { return название; }
            set { название = value; }
        }
        public int A
        {
            get { return год; }
            set { год = value; }
        }
        public Class1()
        { 
           this.гост="null";
            this.название="null";
            this.год = 0;
        }
        public bool equal(Class1 b)
        {
            if (гост.Equals(b.гост) && название.Equals(b.название) && год.Equals(b.год))
                return true;
            else return false;
        }
    }
}
