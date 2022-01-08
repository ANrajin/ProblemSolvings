﻿using System;
using System.Linq;

namespace CF_469A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] x = Console.ReadLine().Split();
            string[] y = Console.ReadLine().Split();

            int len = int.Parse(x[0]) + int.Parse(y[0]);

            int[] _items = new int[len];

            int index = 0;

            for(var i = 1; i <= int.Parse(x[0]); i++)
            {
                _items[index] = int.Parse(x[i]);
                index++;
            }

            for(var j = 1; j <= int.Parse(y[0]); j++)
            {
                _items[index] = int.Parse(y[j]);
                index++;
            }

            var result = _items.Distinct().ToArray();

            if(result.Length == n)
                Console.WriteLine("I become the guy.");
            else
                Console.WriteLine("Oh, my keyboard!");
        }
    }
}
