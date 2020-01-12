using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: поиграться с:
// полиморфизмом,
// интерфейсами
// делегатами
// колллекциями
// словарями
// Обобщениями

namespace OOPLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager manager = new Manager(10000);

            // Тренировка приведения типов (upcast)
            Employee empUp = (Employee)manager;
            //Console.WriteLine(manager.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());

            // Тренировка приведения типов (downcast)
            Manager empDown = (Manager)empUp;

            // Тренировка замещения и переопределения методов
            manager.Print();
            manager.NVPrint();
            empUp.Print();
            empUp.NVPrint();
            empDown.Print();
            empDown.NVPrint();

            // Попытка downcast без предварительного upcast приводит к ошибке компиляции
            //Manager man = (Manager)emp;
            //Console.WriteLine(emp.GetHashCode());
            //Console.WriteLine(man.GetHashCode());

            //manager.Print();
            //Console.WriteLine($"{manager.age} {manager.gender} {manager.Position} {manager.Name} {manager.LastName} {manager.Salary}");
            
            Console.ReadKey();
        }
    }
}
