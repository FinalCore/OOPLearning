using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Events_3
{
    public delegate void KeyPressedDelegate();
    class Program
    {
        public static event KeyPressedDelegate keyPressed = null;

        public static void PressKeyEvent()
        {
            if (keyPressed != null)
                keyPressed.Invoke();
        }

        static void Main(string[] args)
        {
            keyPressed += KeyPressEventHandler;
            Start();
        }

        static void Start()
        {
           
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "a")
                {
                    PressKeyEvent();
                    break;
                }
            }
        }

        public static void KeyPressEventHandler()
        {
            Console.WriteLine("Зачем вы нажали клавишу \"a\"?");
            Console.ReadKey();            
        }
    }

    
}
