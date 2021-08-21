using System;

namespace MaxDivisor
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int b = 5000; ; b--)
            {
                if (b % 39 == 0)
                {
                    Console.WriteLine($"The maximum number divisible by 39 is {b}");
                    break;
                }
           
            }
        }
    }
}
