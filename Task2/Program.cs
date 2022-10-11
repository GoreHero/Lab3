using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Запрос на ввод 
            double A, B, C;
            Console.WriteLine("Введите 3 чмсла");
            Console.Write("Число A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число C: ");
            C = Convert.ToDouble(Console.ReadLine());
            #endregion
            
            if (A == B && A == C)
            {
                Console.WriteLine("Точка А совпадает с точками B и C");                
            }
            else if (B == C)
            {
                Console.WriteLine("Точка А равноудалена от B и C на {0}", Math.Abs(A-B));                
            }
            else
            {
                if (Math.Abs(A - B) < Math.Abs(A - C))
                {
                    Console.WriteLine("Точка B ближе чем точка С к точке А. Расстояние от точки B до точки А = {0}", Math.Abs(A - B));
                }
                else Console.WriteLine("Точка C ближе чем точка B к точке А. Расстояние от точки C до точки А = {0}", Math.Abs(A - C));
            }


        }
    }
}
