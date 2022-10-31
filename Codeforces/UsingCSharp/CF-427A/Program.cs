using System;

namespace CF_427A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split();

            int h = 0;

            int _result = 0;

            for(var i = 0; i < n; i++)
            {
                if (int.Parse(t[i]) > 0)
                    h += int.Parse(t[i]);
                else
                {
                    if (h > 0)
                        h += int.Parse(t[i]);
                    else
                        _result += 1;
                }
            }

            Console.WriteLine(_result);
        }
    }
}
