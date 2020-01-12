using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_IS_AS_cast
{
    class Class_A
    {

    }

    class Class_B : Class_A
    {

    }

    class Program
    {       
        static void Main(string[] args)
        {
            Class_B b = new Class_B();
            Class_A a = null;
            //  Приведение типов при помощи оператора is
            //if (b is Class_A)

            //    a = (Class_A)b;

            //else a = null;
            Console.WriteLine(b is Class_A);

            //Console.WriteLine(a.GetType());

            // Приведение типов при помощи оператора as. Означает, что переменной а присваивается значение переменной b приведенной к типу а (Class_A)
            a = b as Class_A;
            Console.WriteLine(a.GetType());
            Console.ReadKey();

        }
    }
}
