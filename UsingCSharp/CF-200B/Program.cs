using System;

namespace CF_200B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] p = Console.ReadLine().Split();

            decimal add = default;

            for(var i = 0; i < n; i++)
            {
                add += decimal.Parse(p[i]);
            }

            decimal _result = add / n;

            Console.WriteLine(_result.ToString("F12"));
        }
    }
}
