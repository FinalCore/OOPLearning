using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Abstract_classes
{
    class ClassA
    {
    public virtual void Print()
        {
            Console.WriteLine("Print from ClassA");
        }
    }

    abstract class absClassB : ClassA
    {
        /// <summary>
        /// Переопределение метода конкретного класса в абстрактном классе
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("Print from absClassB");
        }
        public abstract void AbsPrint();

    }

    abstract class absClassC : absClassB
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Print from absClassC");
        //}
        public static void StaticPrint()
        {
            Console.WriteLine("Hello from absClassC");
        }
    }

    class ClassD : absClassC
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Print from ClassD");
        //}

        /// <summary>
        /// Реализация абстрактного метода AbsPrint из абстрактного класса absClassB
        /// </summary>
        public override void AbsPrint()
        {
            Console.WriteLine("AbsPrint from classD");
        }

        //  Абстрактные методы можно объявлять только в абстрактных классах
        //public abstract void Paint();
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassD d = new ClassD();
            absClassB b = new ClassD();
            absClassC c = d as absClassC;
            a.Print(); // вызов метода базового конкретного класса
            d.Print(); // вызов метода базового конкретного класса, переопределенный в абстрактном производном классе absClassB
            d.AbsPrint(); // вызов релизации абстрактного метода AbsPrint из производного конеретного класса ClassD 
            c.AbsPrint(); // вызов релизации абстрактного метода AbsPrint из производного конеретного класса ClassD, приведенного к базовому абстрактному классу absClassC 
            c.Print(); // вызов метода, переопределенного в базовом абстрактном классе absClassB
            absClassC.StaticPrint(); //вызов статического метода абстрактного класса без его инстанцирования
            Console.ReadKey();
        }
    }
}
