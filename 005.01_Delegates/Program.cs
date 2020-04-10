using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005._01_Delegates
{
    public class Car
    {
        public int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }
        private bool CarIsDead { get; set; }

        public Car(int maxSpeed, int currSpeed)
        {
            CurrSpeed = currSpeed;
            MaxSpeed = maxSpeed;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        public CarEngineHandler listOfHandlers;

        //public void Accelerate(int delta)
        //{
        //    //if (CarIsDead)
        //        //listOfHandlers(msg1);
        //    else CurrSpeed += delta;
        //    if (MaxSpeed - CurrSpeed <= 10)            
        //        listOfHandlers("Be careful, the engine is hot");
        //    if(CurrSpeed > MaxSpeed)
        //    {
        //        listOfHandlers("Ooops, it seems smbd go home by foot");
        //        CarIsDead = true;
        //    }
        //    else Console.WriteLine($"Current speed = {CurrSpeed}");                
        //}           

    }
    public class Program
    {
        public string msg1 = "Sorry, this car is dead";
        static void Main(string[] args)
        {
            Car car = new Car(120, 20);
        
            void OnCarEngineEvent()
            {

            }
        }
    }
}
