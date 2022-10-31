using System;

namespace CF_486A
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if(n%2 == 0)
            {
                Console.WriteLine(n / 2);
            }
            else
            {
                var p = n / 2d;
                var x = Math.Ceiling(p);
                Console.WriteLine($"-{x}");
            }
        }
    }
}
