﻿using System;

namespace CF_581A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, d1, d2;

            string[] n = Console.ReadLine().Split();

            a = int.Parse(n[0]);
            b = int.Parse(n[1]);

            if (a < b)
                d1 = a;
            else
                d1 = b;

            d2 = (Math.Abs(a - b)) / 2;

            Console.WriteLine("{0} {1}", d1, d2);
        }
    }
}
