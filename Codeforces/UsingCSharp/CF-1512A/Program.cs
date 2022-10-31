using System;

namespace CF_1512A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                t--;

                int n = int.Parse(Console.ReadLine());
                string[] x = Console.ReadLine().Split();

                int result = 1;

                for(var i  = 0; i < x.Length; i++)
                {
                    if(int.Parse(x[i]) - int.Parse(x[i + 1]) != 0)
                    {
                        result += i;
                        break;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
