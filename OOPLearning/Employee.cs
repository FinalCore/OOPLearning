using System;
using System.Collections.Generic;
using System.Text;


namespace OOPLearning
{
    class Employee : Human
    {
        //protected string Name { get; set; } 
        //protected string LastName { get; set; }
        string position;
        public string Position 
        { 
            get {return this.position; }
            set { if (value != "fool") this.position = value; }
        }

        internal Employee()
        {

        }

        internal Employee(string name, string lastName)
        {
            Name = name;
            this.LastName = lastName;
        }
        internal Employee(string position) : this("Johnn", "Smith")
        {
            this.Position = position;          
        }

        /// <summary>
        /// Реализация метода Print из базового абстрактного класса
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("EmployeeClass method Print");
        }

        //  Метод, который будет замещен в производном классе 
        public virtual void NVPrint()
        {
            Console.WriteLine("EmployeeClass NVmethod NVPrint");
        }
    }
}
