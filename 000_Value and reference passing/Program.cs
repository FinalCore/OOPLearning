using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Value_and_reference_passing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p = new Person("Fred", 12);
            p.Display();
            //Передача полей класса (ссылочного типа) по значению
            // SendAPersonByValue(p);
            SendAPersonByReference(ref p);
            p.Display();
            Console.ReadKey();
        }

        //Метод для передачи полей класса (ссылочного типа) по значению
        static void SendAPersonByValue(Person p)
        {
            p.age = 99;
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.age = 999;
            p = new Person("Nikki", 999);
        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() { }

        public void Display()
        {
            Console.WriteLine($"{this.name} {this.age}");
        }
    }
}
