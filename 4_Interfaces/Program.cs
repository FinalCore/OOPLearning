using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interfaces
{
    internal interface IMyInterface
    {
        void Print();      
    }

    internal interface IMyAnotherInterface : IMyInterface
    {
        void AlternativePrint();
        
    }

    internal interface INewInterface : ICloneable
    {
        void Display();
    }

    internal class MyClass : IMyAnotherInterface, INewInterface
    {
        /// <summary>
        /// Реализация метода базового интерфейса IMyInterface
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.GetType());
        }

        /// <summary>
        /// Реализация метода производного интерфейса IMyAnotherInterface
        /// </summary>
        public void AlternativePrint()
        {
            Console.WriteLine("Print from derived Interface");
        }

        /// <summary>
        /// Реализация метода другого интерфейса INewInterface
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Hello from INewInterface");
        }

        /// <summary>
        /// Реализация метода Clone интерфейса IClonable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MyClass myClassCopy = this;
            return myClassCopy;
        }
    }

    internal class MyDerivedClass : MyClass, IMyInterface
    {
        /// <summary>
        /// Замещение реализации метода базового интерфейса IMyInterface, представленной в базовом классе MyClass
        /// </summary>
        void IMyInterface.Print() => Console.WriteLine(this.GetType());
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            
            // различные варианты присвоения значений переменным, имеющим тип интерфейса

            // вариант 1
            MyClass myClass = new MyClass();
            myClass.Print();
            IMyInterface myInterface = (IMyInterface)myClass;
            myInterface.Print();
            Console.WriteLine(new string('-', 30));
            // вариант 2
            IMyAnotherInterface myAnotherInterface = new MyClass();

            // вариант 3
            INewInterface myNewInterface = myClass as INewInterface;

            myNewInterface.Display();
            Console.WriteLine(new string('-', 30));
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.Print();
            Console.ReadKey();
        }
    }
}
