using System;

namespace CF_1335A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                t--;

                long n = long.Parse(Console.ReadLine());
                decimal nd = Convert.ToDecimal(n);

                nd = Math.Ceiling(nd / 2);

                Console.WriteLine(nd - 1);
            }
        }
    }
}
