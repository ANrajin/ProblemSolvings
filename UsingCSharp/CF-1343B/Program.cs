﻿using System;
using System.Text;

namespace CF_1343B
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                t--;

                int n = int.Parse(Console.ReadLine());

                if(n%4 == 0)
                {
                    n /= 2;
                    StringBuilder _result = new StringBuilder();

                    for (var i = 1; i <= n; i++)
                        _result.Append($"{i*2} ");

                    for (var i = 1; i < n; i++)
                        _result.Append($"{i*2 - 1} ");
                    _result.Append(3*n-1);

                    Console.WriteLine("YES");
                    Console.WriteLine(_result.ToString());
                }
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
