using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    abstract class Human
    {
        internal int age;
        internal string gender;

        public string Name { get; set; }
        public string LastName { get; set; }

        public Human()
        {
            this.age = default;
            this.gender = "male";
        }

        //  Метод в базовом абстрактном классе может быть реализован
        //public virtual void Print()
        //{
        //    Console.WriteLine("Method Print from Human class");
        //}

        //  ...либо помечен как абстрактный и реализован в производных классах
        public abstract void Print();

        public void SayHello()
        {
            Console.WriteLine($"Hello, I am {this.Name}");           
        }
    }
}
