using System;

namespace _2_FinaltermTest_MDT112Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("");
            b = int.Parse(Console.ReadLine());

            int c;
            Console.Write("");
            c = int.Parse(Console.ReadLine());

            int d;
            Console.Write("");
            d = int.Parse(Console.ReadLine());

            int e;
            Console.Write("");
            e = int.Parse(Console.ReadLine());

            int f;
            Console.Write("");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine("Banking’s Sort {3} {4} {5} {2} {1}", a, b, c, d, e, f);
            Console.WriteLine("Phun’s Sort {3} {4} {5} {2} {1}", a, b, c, d, e, f);
            Console.WriteLine("Nhong’s Sort {3} {4} {5} {2} {1}", a, b, c, d, e, f);
            Console.WriteLine("Toddy’s Sort {3} {4} {5} {2} {1}", a, b, c, d, e, f);

            Console.ReadLine();
        }
    }
}
