using System;

namespace CF_1409A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            long a, b, _result;

            t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                string[] k = Console.ReadLine().Split();

                a = long.Parse(k[0]);
                b = long.Parse(k[1]);

                _result = Math.Abs(a-b) + 9;
                _result = _result / 10;

                Console.WriteLine(_result);

                t--;
            }
        }
    }
}
