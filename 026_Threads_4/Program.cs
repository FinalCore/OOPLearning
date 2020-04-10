using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _026_Threads_4
{
    class Program
    {
        static object block = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                new Thread(MyThreadMethod).Start();
                Thread.Sleep(500);
                //thread.Start();
            }
                
            Console.ReadLine();
        }

        static void MyThreadMethod()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Thread id = {hash} counter = {i}");
                    Thread.Sleep(200);
                }
                Console.WriteLine(new string('-', 20));
            }

            
        }
    }
}
