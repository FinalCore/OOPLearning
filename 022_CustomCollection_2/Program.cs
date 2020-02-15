using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_CustomCollection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}
