using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Project
{
    class Element : IComparable
    {
        string name;
        int number;

        public string Name { get { return name; } set { name = value; } } 
        public int Number { get { return number; } set { number = value; } } 

        public Element (string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public int CompareTo(object obj)
        {

            if (this.number > ((Element)obj).number)
                return 1;
            else if (this.number == ((Element)obj).number)
                return 0;
            else return -1;
        }
    }
}
