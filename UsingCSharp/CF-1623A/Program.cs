using System;

namespace CF_1623A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(var i = 0; i < t; i++)
            {
                int _result = 0;

                string[] test = Console.ReadLine().Split();

                int n, m, rb, cb, rd, cd;

                n = int.Parse(test[0]);
                m = int.Parse(test[1]);
                rb = int.Parse(test[2]);
                cb = int.Parse(test[3]);
                rd = int.Parse(test[4]);
                cd = int.Parse(test[5]);

                bool check = true;
                bool ri = true;
                bool ci = true;

                int[,] floor = new int[n, m];

                while (check)
                {
                    if (rb == rd || cb == cd)
                        check = false;
                    else
                    {
                        if (rb != n && ri)
                            rb++;
                        else
                        {
                            ri = false;
                            rb--;
                        }

                        if (cb != m && ci)
                            cb++;
                        else
                        {
                            ci = false;
                            cb--;
                        }

                        _result += 1;
                    }
                }

                Console.WriteLine(_result);
            }
        }
    }
}
