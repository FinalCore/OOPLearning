using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Yield_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод данных для итератора, полученного в методе GetBooks;
            Library libr = new Library();
            foreach(Book b in libr)
            {
                Console.WriteLine(b.Name);
            }

            //Вывод данных для итератора, полученного в методе GetBooks;
            //foreach (Book b in libr.GetBooks(5))
            //{
            //    Console.WriteLine(b.Name);
            //}
            //Console.ReadLine();

            Console.ReadLine();
        }
    }
}
