using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in Fibonacci(10))
                Console.WriteLine(item);
            
            Console.ReadKey();
        }

        static IEnumerable<int> Fibonacci(int count)
        {
            int prev = 1;
            int curr = 1;

            for (int i = 0; i < count; i++)
            {
                yield return prev;
                int temp = prev + curr;
                prev = curr;
                curr = temp;
            }
        }
    }
}
