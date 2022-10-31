using System;

namespace CF_339A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split('+');

            Array.Sort(s);

            var result = String.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                result += s[i];

                if (i + 1 != s.Length)
                {
                    result += '+';
                }
            }

            Console.WriteLine(result);
        }
    }
}
