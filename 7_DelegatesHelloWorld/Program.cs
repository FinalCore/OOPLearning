using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_DelegatesHelloWorld
{
    delegate string Delegate1(); 
    //delegate void Delegate2(); 
    delegate string Delegate3(); 
    class Program
    {
        static void Main(string[] args)
        {
            Delegate1 del1 = () => "Hello", del2 = () => "World";            
            Delegate3 del3 = () => del1() + ", " + del2() + "!";
            Console.WriteLine(del3());
            Console.ReadKey();
        }
    }
}
