using System;

namespace CSh_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex_1();
            Ex_2();
        }

        static void Ex_1()
        {
            int x_begin = -10, x_end = 8;
            double x, y, dx;

            Console.Write("dx = ");
            dx = Convert.ToDouble(Console.ReadLine());

            x = x_begin;
            y = -3;

            Console.WriteLine("     x     |    y     ");

            while (x <= x_end)
            {
                if (x <= -8) y = -3;
                if (x > -8 & x <= -3) y = 1.6 * x + 1.8;
                if (x > -3 & x <= 3) y = Math.Sqrt(9 - x * x);
                if (x > 3 & x <= 5) y = x - 3;
                if (x > 5) y = 3;

                Console.WriteLine($"{Math.Round(x, 3),10} | {Math.Round(y, 3),10}");
                x += dx;
            }

        }

        static void Ex_2()
        {
            int a;
            for (int i = 10; i < 100; i++)
            {
                a = i * i;
                if (a / 1000 == 0)
                {
                    if (a / 100 == a % 10) Console.WriteLine(a);
                }
                else
                {
                    if ((a / 1000 == a % 10) & ((a / 100) % 10 == (a % 100) / 10)) Console.WriteLine(a);
                }
                
            }
        }
    }
}
