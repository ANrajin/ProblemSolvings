using System;
using System.Collections.Generic;
using System.Linq;

namespace CF_490A
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            List<int> arr = str.Select(s => int.Parse(s)).ToList();

            bool check = arr.Contains(1) && arr.Contains(2) && arr.Contains(3);

            if(!check)
                Console.WriteLine(0);
            else
            {
                double teams = Math.Floor(n/3);

                int[,] team = new int[4, 3];

                for(var i = 0; i < teams; i++)
                {
                    int ti = 1;

                    for(var j = 0; j < arr.Count; j++)
                    {
                        if (ti > 3)
                        {
                            Console.Write("\n");
                            break;
                        }

                        if(arr[j] == ti)
                        {
                            ti++;
                            Console.Write($"{j + 1} ");
                            arr.RemoveAt(j);
                            arr.Insert(j, 0);
                            j = 0;
                        }
                    }
                }
            }
        }
    }
}
