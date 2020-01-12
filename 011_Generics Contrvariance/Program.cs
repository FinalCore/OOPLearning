using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Generics_Contrvariance
{
    public abstract class Shape { };
    public class Circle : Shape { };

    public interface IContainer<in T>
    {
        T Figure { set; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;
        public T Figure { set { this.figure = value; } }
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
            Shape circle = new Circle();
            // Контрвариантность - это downcast параметра типа. В данном случае параметр типа Shape приводится к производному для него типу Circle
            IContainer<Circle> container = new Container<Shape>(circle);
            Console.WriteLine(container.ToString());
            Console.ReadKey();
        }

    }
}
