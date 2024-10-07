using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class People
    {
        private string name { get; set; }

        public People() { }
        public People (string a_name)
        {
            name = a_name;
        }

        public string getPersonName()
        {
            return name;
        }
    }
}
