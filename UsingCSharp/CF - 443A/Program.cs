using System;
using System.Linq;

namespace CF___443A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.Replace("{", "").Replace("}", "").Replace(",", "");

            if (str.Length > 0)
            {
                string[] arr = str.Split();
                var _result = arr.Distinct().ToArray();
                Console.WriteLine(_result.Length);
            }
            else
                Console.WriteLine(str.Length);
        }
    }
}
