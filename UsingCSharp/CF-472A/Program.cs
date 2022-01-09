using System;

namespace CF_472A
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            var half = Math.Floor(n/2);
            var diff = n - half;

            while(IsPrime(half) || IsPrime(diff))
            {
                half++;
                diff--;
            }

            Console.WriteLine($"{half} {diff}");
        }

        static bool IsPrime(double num)
        {
            bool prime = true;

            for(var i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
