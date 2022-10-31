using System;

namespace CF_1328A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(var i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();

                long a = long.Parse(str[0]);
                long b = long.Parse(str[1]);

                long _remain = b - (a % b);

                if(_remain == b)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(_remain);
            }
        }
    }
}
