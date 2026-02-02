using System;

namespace OperadpresComparacaoLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("------------");

            bool b1 = 2 > 3 || 4 != 5; // true
            bool b2 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine("--------------");
            bool b3 = 10 < 5; // false
            bool b4 = c1 || c2 && c3; // true
            Console.WriteLine(b3);
            Console.WriteLine(b4);
        }
    }
}
