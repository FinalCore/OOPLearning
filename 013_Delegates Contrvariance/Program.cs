using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Delegates_Contrvariance
{
    class Animal { }
    class Cat : Animal { }

    delegate void MyDelegate<in T>(T input);
    class Program
    {
        static void CatUser (Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }
        static void Main(string[] args)
        {            
            MyDelegate<Animal> delAnimal = CatUser;
            MyDelegate<Cat> delCat = delAnimal;
            //delCat(new Animal); невозможно создать. Будет ошибка компиляции, поскольку для downcast нужен предварительный upcast
            delAnimal(new Animal());
            delCat(new Cat());
            Console.ReadKey();

        }
    }
}
