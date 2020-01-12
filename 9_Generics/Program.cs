using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics
{
    public abstract class Shape { };
    public class Circle : Shape { };

    public interface IContainer<out T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }
        public Container(T figure)
        {
            this.Figure = figure;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            IContainer<Circle> container = new Container<Circle>(circle);
            //такое приведение  Container<Circle> к IContainer<Shape> возможно только за счет применения ковариантности и ключевого слова out
            IContainer<Shape> container2 = new Container<Circle>(circle);
            Console.WriteLine(container.Figure.ToString());
            Console.WriteLine(container2.Figure.ToString());
            Console.ReadKey();
        }

    }
}
