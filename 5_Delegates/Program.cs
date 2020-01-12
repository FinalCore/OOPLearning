using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Delegates
{
    public delegate void MyDelegate(int a, int b);
    public delegate int AnonymDel();
    public delegate int LambdaDel(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //int a = 0, b = 0;
            //MyDelegate del1 = new MyDelegate(MyClass.Add);
            //MyDelegate del2 = new MyDelegate(MyClass.Mult);
            //MyDelegate del3 = del2 - del1;
            //del1(5, 4);
            //del2(5, 4);
            //del3(5, 4);

            //Передача делегату анонимного (лямбда) метода. Также используется техника предположения делегата
            AnonymDel anDel = delegate { Console.WriteLine("Hello, World!"); return 10; };
            //Передача делегату лямбда оператора 
            LambdaDel lDel = (x, y) => { return (x + y); };
            //Передача делегату лямбда выражения 
            LambdaDel lDel2 = (x, y) => x + y;
            anDel();
            lDel(10, 2);
            lDel2(3, 7);
            Console.ReadKey();
        }      
    }

    class MyClass
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mult(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
