﻿using System;
using System.Linq;

namespace CF_228A
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = Console.ReadLine().Split();

            int[] shoes = new int[colors.Length];

            var i = 0;

            foreach(var color in colors)
            {
                shoes[i++] = int.Parse(color);
            }

            var selectedShoes = shoes.Distinct();

            var required = Math.Abs(shoes.Length - selectedShoes.ToArray().Length);

            Console.WriteLine(required);
        }
    }
}
