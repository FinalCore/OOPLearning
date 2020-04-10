using System;
using System.Threading.Tasks;
using System.Threading;

namespace _024_Threads_2
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Работа вторичного потока
            Thread thread = new Thread(MyThreadMethod);
            thread.Start();
            // Работа первичного потока
            MyThreadMethod();
            Console.ReadLine();
        }

        static void MyThreadMethod()
        {
            Thread.Sleep(200);
            int counter = 10;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Thread Id {Thread.CurrentThread.GetHashCode()} Counter = {i}");
            }
        }
    }
}
