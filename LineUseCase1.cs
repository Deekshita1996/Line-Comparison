using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineUseCase1
    {
        public static void CalLength()
        {
            Console.Write("Enter Value A1:");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value B1:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value A2:");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value B2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double value = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Ans Is:" + value);
        }
    }
}
