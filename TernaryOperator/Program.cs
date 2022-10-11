using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fNum = Convert.ToInt32(Console.ReadLine());
            int sNum = Convert.ToInt32(Console.ReadLine());
            int max = (fNum > sNum) ? fNum : sNum;
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
