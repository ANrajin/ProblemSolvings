using System;
using System.Collections.Generic;
using System.Linq;

namespace CF___1624B
{
    class Program
    {
        //Unsolved
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                t--;
                string[] str = Console.ReadLine().Split();
                List<int> arr = str.Select(s => int.Parse(s)).ToList();
                int min = int.Parse(str[0]);
                int imin = default;

                for(var i = 0; i < 3; i++)
                {
                    if (int.Parse(str[i]) < min)
                    {
                        min = int.Parse(str[i]);
                        imin = i;
                    }
                }

                int x = default;

                if (imin == 0)
                    x = 2 * arr[1] - arr[2];
                else if (imin == 1)
                    x = (arr[0] + arr[2]) / 2;
                else
                    x = 2 * arr[2] - arr[0];

                arr.RemoveAt(imin);

                if (Math.Abs(arr[0] - x) == Math.Abs(arr[1] - x))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
