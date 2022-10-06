using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineUseCase2
    {
        public static void calEquality()
        {
            // for line 1

            Console.WriteLine("Enter the value A1:");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value A2:");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value B1:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value B2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double ans1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Ans is :" + ans1);
            Console.WriteLine("------------------------------------------------");


            // for line 2

            Console.WriteLine("Enter the value C1:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value C2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value D1:");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value D2:");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double ans2 = Math.Sqrt(Math.Pow((c2 - c1), 2 )+ Math.Pow((d2 - d1), 2));
            Console.WriteLine("Ans is :" + ans2);
            Console.WriteLine("---------------------------------------------------");

            //comparing both lines

            if (ans1 == ans2) ;
            {
                Console.WriteLine("Both Lines Are Equal");
            }
            
            {
                Console.WriteLine("Both Lines Are Not Equal");
            }
        }
    }
}