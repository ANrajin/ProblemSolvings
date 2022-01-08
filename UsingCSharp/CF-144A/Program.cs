using System;

namespace CF_144A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();

            int imax = default;
            int imin = default;
            int maxNum = default;
            int minNum = 101;

            for(var i = 0; i < str.Length; i++)
            {
                if(int.Parse(str[i]) > maxNum)
                {
                    maxNum = int.Parse(str[i]);
                    imax = i;
                }

                if(int.Parse(str[i]) <= minNum)
                {
                    minNum = int.Parse(str[i]);
                    imin = i;
                }
            }

            if (imax > imin)
                imin++;

            Console.WriteLine(imax + (t - 1) - imin);
        }
    }
}
