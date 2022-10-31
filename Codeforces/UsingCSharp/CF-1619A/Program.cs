using System;

namespace CF_1619A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(var i = 1; i <= t; i++)
            {
                string s = Console.ReadLine();

                if(s.Length%2 != 0)
                    Console.WriteLine("NO");
                else
                {
                    int x = s.Length - s.Length / 2;
                    if (s.Substring(0, x) == s.Substring(x))
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
            }
        }
    }
}
