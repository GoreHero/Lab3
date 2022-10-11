using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество грибов найденых в лесу:");
            int n = Convert.ToInt32(Console.ReadLine());
            int o = n % 10;
            if (n%100 >= 11 && n%100 <= 19)
            {
                Console.WriteLine("Мы нашли {0} грибов", n);
            }
            else
            {
                switch (o)
                {
                    case 0:
                        Console.WriteLine("Мы нашли {0} гриб", n);
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Мы нашли {0} гриба", n);
                        break;
                    default:
                        Console.WriteLine("Мы нашли {0} грибов", n);
                        break;
                }
            } 
            Console.ReadKey();
             
        }
    }
}
