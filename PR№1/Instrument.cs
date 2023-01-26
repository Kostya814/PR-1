using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class Instrument
    {
        private string name;
        private int count;

        public Instrument(string name,int count) 
        {
            this.name = name;
            this.count = count;
        }
        public string getName()
        { 
            return name;
        }
        public int getCount()
        {
            return count;
        }
    }
}
