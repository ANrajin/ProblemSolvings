using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CF_1154A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int imax = default;
            long max = default;
            StringBuilder _result = new StringBuilder();

            List<long> arr = str.Select(s => long.Parse(s)).ToList();
            arr.Sort();

            for(var i = 0; i < arr.Count; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    imax = i;
                }
            }

            for(var i = 0; i < arr.Count; i++)
            {
                if (i == imax)
                    continue;

                long diff = Math.Abs(max - arr[i]);
                _result.Append($"{diff} ");
            }

            Console.WriteLine(_result.ToString());
        }
    }
}
