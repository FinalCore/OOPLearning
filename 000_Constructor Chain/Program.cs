using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Constructor_Chain
{
    #region Цепочка конструкторов на примере базового класса

    public class Animal
    {
        string type;
        int age;
        int weight;
        bool isMale;

        public Animal() { }

        public Animal(string t)
        {
            type = t;
        }

        public Animal(string t, int a) : this(t)
        {
            age = a;
        }
             
        public Animal (string t, int a, int w, bool isMale) : this (t, a)
        {
            weight = w;
            this.isMale = isMale;
        }
    }



    #endregion

    #region Цепочка конструкторов и наследование
    public class Person
    {
        int Id;
        string name;

        public Person(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }
    }

    public class Employee : Person 
    {
        string position;
        public Employee (string position, int id, string name) : base (id, name)
        {
            this.position = position;
        }
    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Animal c = new Animal("cat");
            Animal b = new Animal("lion", 5, 150, true);

            Person p = new Person(1, "Vasya");
            Employee e = new Employee("manager", 1, "Petya");

        }
    }
}
