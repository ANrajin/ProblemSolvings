﻿using System;

namespace CF_750A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int diff = 240 - int.Parse(str[1]);
            int min = default;
            int count = default;

            for(var i = 1; i <= int.Parse(str[0]); i++)
            {
                min += 5 * i;
                if (min <= diff)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
