using System;
using System.Collections.Generic;

namespace CF_490A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();

            List<int> arr = new List<int>();

            foreach(var s in str)
            {
                arr.Add(int.Parse(s));
            }

            var team = Math.Floor((decimal)t / 3);

            Console.WriteLine(team);

            for(var i = 1; i <=team; i++)
            {
                int n = 1;

                for(var j = 0; j < t; j++)
                {
                    if(arr.Contains(n) && arr[j] == n)
                    {
                        Console.Write($"{j + 1} ");
                        arr.Remove(arr[i]);
                        n++;
                    }
                }
            }
        }
    }
}
