using System;

namespace _016_Events_2
{
    delegate void MyDelegate(int n);
    class Source
    {
        public MyDelegate del = null;
        int currentTime;
        int difference; 
        ulong counter = 0;
        int seconds = 0;
        public void Countdown()
        {
            int startTime = DateTime.Now.Second;
            var targetTime = startTime + 2;

            while (true)
            {
                currentTime = DateTime.Now.Second;
                counter++;
               difference = targetTime - currentTime;
                if (difference <= 0)
                {
                    targetTime = currentTime + 2;
                    seconds += 2;
                    del.Invoke(seconds);
                }
                
            }
        }
    }

    class Handler
    {
        public void HandlerMethod(int n)
        {
            Console.WriteLine("Прошло {0} секунд", n);
        }
    }     
           
    class Program
    {
        static void Main(string[] args)
        {
            Source s = new Source();
            Handler h = new Handler();
            s.del += h.HandlerMethod;            
            s.Countdown();
            Console.ReadKey();
        }
    }
}
