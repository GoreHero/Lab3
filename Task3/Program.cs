using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Число");
            byte num = Convert.ToByte(Console.ReadLine());
            
            byte a = (byte)((num - num %10)/10); //целое
            byte b = (byte)(num % 10); //остаток
            
            switch (a)
            {
                case 2:
                    {
                        Console.Write("Двадцать ");
                        break;
                    }                    
                case 3:
                    {
                        Console.Write("тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("Пятьдесят ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("Шестьдесят ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        Environment.Exit(0);
                        break;
                    }
                    
            }

            switch (b)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("один год");
                        break;
                    }
                    
                case 2:
                    {
                        Console.WriteLine("два года");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("три года");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("четыре года");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("пять лет");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("шесть лет");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("семь лет");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("восемь лет");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("девять лет");
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
