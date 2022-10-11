using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = num - (num % 100);     //100
            int b = num % 100 - num % 10;  //10
            int c = num % 10;              //1

            #region обработка сотых
            switch (a)
            {
                case 100:
                    {
                        Console.Write("Сто ");
                        break;
                    }
                case 200:
                    {
                        Console.Write("Двести ");
                        break;
                    }
                case 300:
                    {
                        Console.Write("Триста ");
                        break;
                    }
                case 400:
                    {
                        Console.Write("Четыреста ");
                        break;
                    }
                case 500:
                    {
                        Console.Write("Пятьсот ");
                        break;
                    }
                case 600:
                    {
                        Console.Write("Шестьсот ");
                        break;
                    }
                case 700:
                    {
                        Console.Write("Семьсот ");
                        break;
                    }
                case 800:
                    {
                        Console.Write("Восемьсот ");
                        break;
                    }
                case 900:
                    {
                        Console.Write("Девятьсот ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка. Число вне диапозона от 100 до 999");
                        Environment.Exit(0);
                        break;
                    }
            }
            #endregion

            #region обработка десятых + уникальных
            switch (b)
            {
                case (10):
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("десять");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 1)
                        {
                            Console.WriteLine("одинадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 2)
                        {
                            Console.WriteLine("двенадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 3)
                        {
                            Console.WriteLine("тринадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 4)
                        {
                            Console.WriteLine("четырнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 5)
                        {
                            Console.WriteLine("пятнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 6)
                        {
                            Console.WriteLine("шестнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 7)
                        {
                            Console.WriteLine("семнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 8)
                        {
                            Console.WriteLine("восемьнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        else if (c == 9)
                        {
                            Console.WriteLine("девятнадцать");
                            Environment.Exit(0);
                            break;
                        }
                        break;

                    }
                

                case (20):
                {
                        Console.Write("двадцать ");
                        break;
                }
                case (30):
                    {
                        Console.Write("тридцать ");
                        break;
                    }
                case (40):
                    {
                        Console.Write("сорок ");
                        break;
                    }
                case (50):
                    {
                        Console.Write("пятьдесят ");
                        break;
                    }
                case (60):
                    {
                        Console.Write("шестьдесят ");
                        break;
                    }
                case (70):
                    {
                        Console.Write("семьдесят ");
                        break;
                    }
                case (80):
                    {
                        Console.Write("восемьдесят ");
                        break;
                    }
                case (90):
                    {
                        Console.Write("девяносто ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        Environment.Exit(0);
                        break;
                    }

            }
            #endregion

            #region обработка единиц
            switch (c)
            {

                case 1:
                    {
                        Console.WriteLine("один");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("два");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("три");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("четыре");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("пять");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("шесть");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("семь");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("восемь");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("девять");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        Environment.Exit(0);
                        break;
                    }
            }
            #endregion
        }
    }
}
