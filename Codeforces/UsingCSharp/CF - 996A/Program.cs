using System;

namespace CF___996A
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long count = default;

            int[] dollar = new int[]
            {
                1 , 5, 10, 20, 100
            };

            while (n > 0)
            {
                for (var i = dollar.Length - 1; i >= 0; i--)
                {
                    if (dollar[i] <= n)
                    {
                        n -= dollar[i];
                        count += 1;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
