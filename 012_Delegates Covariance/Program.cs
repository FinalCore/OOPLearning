using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Delegates_Covariance
{
    abstract class Animal { };
    class Cat : Animal 
    {
        public static Cat CatCreator()
        {
            return new Cat();
        }
    }
    class Program
    {
        delegate T MyDelegate<out T>();
        static void Main(string[] args)
        {
            MyDelegate<Cat> delCat = Cat.CatCreator;
            MyDelegate<Animal> delAnimal = delCat;
            delAnimal();
            Console.WriteLine(delAnimal.GetType().Name);
            Console.ReadLine();
        }
    }
}
