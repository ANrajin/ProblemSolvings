using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CF_490A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            List<int> arr = str.Select(s => int.Parse(s)).ToList();

            bool check = arr.Contains(1) && arr.Contains(2) && arr.Contains(3);

            if(!check)
                Console.WriteLine(0);
            else
            {

            }
        }
    }
}
