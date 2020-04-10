using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace _025_Threads_3
{
    //Объявляем класс, поля которого будут использваться в методе, запускаемом во вторичном потоке
    class Argument
    {
       public int number = 10;
       public string name = "Hello, World!";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем вторичный поток. в который передаем метод, параметризованный одним аргументом
            Thread thread = new Thread(MyThreadMethod);
            // Запускаем вторичный поток
            thread.Start(new Argument());
            Console.ReadLine();
        }        

        static void MyThreadMethod(object argument)
        {
            // Приводим параметр, передаваемы в метод, к типу Argument для того, чтобы получить доступ к полям класса Argument
            Argument arg = (Argument)argument;
            // Теперь мы можем использовать поля класса
            for (int i = 0; i < arg.number; i++)
            {
                Console.WriteLine(arg.name);
            }

        }
    }
}
