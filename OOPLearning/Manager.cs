using System;
using System.Collections.Generic;
using System.Text;


namespace OOPLearning
{
    class Manager : Employee
    {
        public double Salary { get; set; }
        internal Manager(double salary) : base("manager")
        {
            this.Salary = salary;
        }

        //  Метод может либо замещать метод базового класса
        //public new void Print()
        //{
        //    Console.WriteLine("Manager class method Print");
        //}

        //  ...либо переопределять его
        //  При upcast будет вызван метод, переопределенный в производном классе
        public override void Print()
        {
            Console.WriteLine("Manager class method Print");
        }

        //  Замещение метода базового класса. При upcast будет вызван метод базового класса
        public new void NVPrint()
        {
            Console.WriteLine("ManagerClass NVmethod NVPrint");
        }
    }
}
