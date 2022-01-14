﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CF_758A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();

            if(n < 2)
            {
                Console.WriteLine(0);
                return;
            }

            List<int> arr = str.Select(s => int.Parse(s)).ToList();
            int max = default;
            int _result = default;

            for (var i = 0; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            for(var i = 0; i < n; i++)
            {
                if (arr[i] < max)
                   _result += max - arr[i];
            }

            Console.WriteLine(_result);
        }
    }
}
