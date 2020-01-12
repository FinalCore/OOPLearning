using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Generics
{
    delegate R MyDelegate<T, R>(T t);
    class Program
    {
        static int Add(int a)
        {
            return a++;
        }

        static string Concatenation(string name)
        {
            return "Hello, " + name;
        }

        static string PrintString<P>(P input)
        {
            return input.ToString();
        }

        static void Main(string[] args)
        {
            MyDelegate<int, int> del1 = Add;
            MyDelegate<string, string> del2 = Concatenation;
            MyDelegate<double, string> del3 = PrintString;

            Console.WriteLine(del1(10));
            Console.WriteLine(del2("Vasya"));
            Console.WriteLine(del3(101.2334));
            Console.ReadKey();
        }
    }
}
