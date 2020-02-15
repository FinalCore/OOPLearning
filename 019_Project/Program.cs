using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection MyCollection = new UserCollection();
            // Используем штатный цикл foreach
            //foreach (Element element in MyCollection)
            //{
            //    Console.WriteLine($"{element.Name} {element.Number}");
            //}
            

            //Самостоятельно реализеуем перебор всеъ элементов коллекции
            //Console.Write(new string ('-', 29) + "\n");
            //MyCollection.Reset();
            //while (MyCollection.MoveNext() == true)
            //{
            //    Element element = (Element)MyCollection.Current;
            //    Console.WriteLine($"{element.Name} {element.Number}");
            //}

            //более правильный вариант
            IEnumerable enumerable = MyCollection as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext() == true)
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine($"{element.Name} {element.Number}");
            }

            Console.ReadKey();
        }
    }
}
