using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region запрос данных
            int x1, x2, x3, y1, y2, y3, x4, y4;
            Console.WriteLine("Необходимо ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям");
            Console.WriteLine("Введите координаты 1й точки");
            Console.Write("X: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 2й точки");
            Console.Write("X: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 3й точки");
            Console.Write("X: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            #endregion

            x4 = 0;
            y4 = 0;
            bool flag = true;

            #region Проверка соответствия по оси Х
            {
                if (x1 == x2)
                {
                    x4 = x3;
                }
                else if (x2 == x3)
                {
                    x4 = x1;
                }
                else if (x3 == x1)
                {
                    x4 = x2;
                }
                else if (x2 == x3)
                {
                    x4 = x1;
                }
                else flag = false;
            }
            #endregion

            #region Проверка соответствия по оси Y
            {
                if (y1 == y2)
                {
                    y4 = y3;
                }
                else if (y2 == y3)
                {
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    y4 = y2;
                }
                else if (y2 == y3)
                {
                    y4 = y1;
                }
                else flag = false;
            }
            #endregion

            {
                if (flag == true)
                {
                    Console.WriteLine("четвертая координата прямоугольника = {0},{1}", x4, y4);
                }
                else Console.WriteLine("Стороны прямоугольника не параллельны осям X Y");
            }
            Console.ReadKey();
        }
    }
}
