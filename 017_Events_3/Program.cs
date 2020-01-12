using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Events_3
{
    public delegate void del(byte i);
    public delegate void finalDel();
    class Program
    {
        public static event del flag = null;
        public static event finalDel finalFlag = null;
        static int deadline = 22;
        static void Main(string[] args)
        {
            flag += EventHandler;
            finalFlag = finalEventHandler;
            Countdown(deadline);
            Console.ReadKey();
        }

        static void Countdown(int deadline)
        {
            DateTime startTime = DateTime.Now;
            DateTime currentTime = startTime;
            long counter = 0;
            byte iterations = 0;
            while (true)
            {
                if ((DateTime.Now - currentTime).TotalSeconds >= 4)
                {
                    currentTime = DateTime.Now;
                    iterations++;
                    flag.Invoke(iterations);
                }
                if ((DateTime.Now - startTime).TotalSeconds >= deadline)
                {
                    finalFlag.Invoke();
                    return;
                }
                counter++;
            }
        }

        static void EventHandler(byte iterations)
        {
            Console.WriteLine("Осталось {0} секунд", deadline - iterations * 4);
        }
        static void finalEventHandler()
        {
            Console.WriteLine("Время вышло");
        }
    }
}
