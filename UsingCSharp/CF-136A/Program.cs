using System;
using System.Linq;
using System.Text;

namespace CF_136A
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder _result = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();

            int[] arr = str.Select(s => int.Parse(s.ToString())).ToArray();

            for(var i = 0; i < arr.Length; i++)
            {
                int x = arr[i];

                _result.Append($"{arr[x]}");
            }
        }
    }
}
