﻿using System;

namespace CF_268A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, hi, ai, _result;

            n = int.Parse(Console.ReadLine());

            int[,] teams = new int[n, 2];

            for(var i = 0;  i < n; i++)
            {
                string[] x = Console.ReadLine().Split();

                teams[i, 0] = int.Parse(x[0]);
                teams[i, 1] = int.Parse(x[1]);
            }

            _result = 0;

            for(var i = 0; i < n; i++)
            {
                hi = teams[i, 1];

                for(var j = 0; j < n; j++)
                {
                    ai = teams[j, 0];

                    if (i != j && hi == ai)
                        _result += 1;
                }
            }

            Console.WriteLine(_result);
        }
    }
}
