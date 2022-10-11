using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            if (x1 == x2 || y1 == y2)
                Console.WriteLine("Точки лежат на прямой параллельной ОХ или ОУ");
            else
                Console.WriteLine("Точки не лежат на прямой параллельной ОХ или ОУ");
            Console.ReadKey();


        }
    }
}
