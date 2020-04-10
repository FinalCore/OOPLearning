using System;
using System.Threading;
using System.Threading.Tasks;


namespace _023_Threads_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(MyThreadMethod));
            thread.Start();
            while (true)
            {
                Console.WriteLine("Primary");
            }
        }

        static void MyThreadMethod()
        {
            while(true)
            {
                Console.WriteLine(new string('-', 10) + "Secondary");
            }
        }
    }
}
