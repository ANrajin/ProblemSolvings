using System;

namespace CF_732A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();

            int k = int.Parse(n[0]);
            int r = int.Parse(n[1]);

            int x = 1;

            while (true)
            {
                if(x*k % 10 == 0 || x*k%10 == r)
                {
                    Console.WriteLine(x);
                    break;
                }
                x++;
            }
        }
    }
}
