﻿using System;
using System.Text;

namespace CF_1621A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(true)
            {
                if (t > 0)
                    t--;
                else
                    break;

                string[] x = Console.ReadLine().Split();
                int n, k, i, j;

                n = int.Parse(x[0]);
                k = int.Parse(x[1]);
                StringBuilder _r = new StringBuilder();

                for (i = 1; i <= n; i++)
                {
                    for(j = 1; j <= n; j++)
                    {
                        if (j != i || k <= 0 || (i % 2 == 0) && (j % 2 == 0))
                            _r.Append(".");
                        else
                        {
                            _r.Append("R");
                            k--;
                        }
                    }
                    _r.Append("\n");
                }

                if(k > 0)
                    Console.WriteLine("-1");
                else
                    Console.WriteLine(_r.ToString());
            }
        }
    }
}
