using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Events
{    
   class Program
   {
        public static void Main()
        {
            // создаем объект-источник события
            Source s = new Source();
            // создаем объек-подписчик на событие
            Subscriber sub = new Subscriber();
            // вызывваем метод объекта-подписчика, из которого вызывается метод объекта-источника, создающий событие
            // и вызывающий метод-обработчик в объекте-подписчике
            Console.WriteLine(sub.CountTens(s, 48));
            Console.ReadKey();
        }

   }

   // класс, генерирующий событие
   class Source
    {
        // объявляем событие
        public event EventHandler TenIsCounted;
        // зануляем событие в конструкторе класса
        public Source()
        {
            TenIsCounted = null;
        }
        public void Increment(int number)
        {
            for (int i =1; i < number; i++)
            {
                if (i % 10 == 0)
                    // наступление события и вызов методов-обработчиков, подписанных на событие
                    TenIsCounted?.Invoke(this, null);
            }
        }
    }

    // клас-подписчик на событие
    class Subscriber
    {
       int tensNumber = 0;
       public int CountTens(Source s, int number)
        {
            // подписываем класс-подписчик на конкретное событие
            s.TenIsCounted += Handler;
            // вызываем метод класса-источника, в котором наступает нужное событие
            s.Increment(number);
            return tensNumber;
        }
        
        // метод-обработчик события, вызываемый при его наступлении
        public void Handler(object source, EventArgs e)
        {
            tensNumber++;
        }
    }
}
