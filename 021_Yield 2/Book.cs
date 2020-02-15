using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Yield_2
{
    class Book
    {
        string name;
        public string Name { get; set; }
        public Book(string name)
        {
            this.Name = name;
        }
    }

    class Library
    {
        private Book[] books;
        public Library()
        {
            books = new Book[] { new Book("В круге первом"), new Book("Чевенгур"), new Book("Лезвие бритвы")};
        }

        public int Length
        {
            get { return books.Length; }
        }

        //Создание итератора и перебор его значений при помози оператора yield
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Length; i++)
            {
                yield return books[i];
            }
        }

        //Итератор может быть создан в любом методе, не обязательно использовать штатный метод GetEnumerator
        //public IEnumerable GetBooks(int max)
        //{
        //    for (int i = 0; i < max; i++)
        //    {
        //        if (i != books.Length)
        //            yield return books[i];
        //        else yield break;
        //    }
        //}

    }
}
