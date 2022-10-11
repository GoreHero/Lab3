using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int absoluteValue = num;
            if (num < 0)
            {
                absoluteValue = -num;
            }
            Console.WriteLine(absoluteValue);
            Console.ReadKey();
        }
    }
}
