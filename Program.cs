using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers x = new RationalNumbers(1, 2);
            RationalNumbers y = new RationalNumbers(3, 4);
            RationalNumbers sum = x + y;
            RationalNumbers dif = x - y;
            RationalNumbers mult = x * y;
            RationalNumbers div = x / y;
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x < y);
            Console.WriteLine(x > y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x.Equals(y));
        }
    }
}
