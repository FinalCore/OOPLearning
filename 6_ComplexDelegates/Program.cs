using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ComplexDelegates
{
    delegate Delegate2 Delegate1();
    delegate void Delegate2(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Delegate1 myDel1 = () => Method1; // Использована техника предположения делегата
            Delegate2 myDel2 = myDel1();
            myDel2(input);
            Console.ReadKey();
        }

        static void Method1(string text)
        {
            Console.WriteLine(text + "Wow!");
        }
    }
}
