using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("ноль", 0);
            dictionary.Add("один", 1);
            dictionary.Add("два", 2);
            dictionary.Add("три", 3);

            foreach (var item in dictionary)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
