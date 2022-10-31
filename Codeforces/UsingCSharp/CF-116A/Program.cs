using System;

namespace CF_116A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] s = new int[2];

            int result = 0;

            for (var i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split();

                if (s.Length == 0)
                {
                    s[0] = int.Parse(x[0]);
                    s[1] = int.Parse(x[1]);
                }
                else
                {
                    int tmp = s[1] - int.Parse(x[0]) + int.Parse(x[1]);

                    if (tmp > result)
                        result = tmp;

                    s[0] = int.Parse(x[0]);
                    s[1] = tmp;
                }
            }

            Console.WriteLine(result);
        }
    }
}