using System;
using System.Collections.Generic;
using System.Linq;

namespace CF_432A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();

            int n = int.Parse(str1[0]);
            int k = int.Parse(str1[1]);

            string[] str2 = Console.ReadLine().Split();

            List<int> arr = str2.Select(s => int.Parse(s)).ToList();

            for(var i = 0; i< arr.Count; i++)
            {
                if (arr[i] + k <= 5)
                    continue;

                arr.RemoveAt(i);
                i--;
            }

            int team = arr.Count / 3;

            Console.WriteLine(team);
        }
    }
}
