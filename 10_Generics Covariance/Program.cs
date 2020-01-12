using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Generics_Covariance
{
    public abstract class Shape { };
    public class Circle : Shape { };

    public interface IContainer<out T>
    {
        T Figure { get; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;
        public T Figure { get { return figure; } }
        public Container(T figure)
        {
            this.figure = figure;
        }
        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            // Ковариантность - это upcast параметра типа. В данном случае параметр типа Circle приводится к базовому для него типу Shape
            IContainer<Shape> container = new Container<Circle>(circle);
            Console.WriteLine(container.Figure.ToString());
            Console.ReadKey();
        }

    }

}
