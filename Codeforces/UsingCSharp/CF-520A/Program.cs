using System;

namespace CF_520A
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabets = new char[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o','p','q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            int n = int.Parse(Console.ReadLine());

            string str = Console.ReadLine().ToLower();

            int i = 0;

            while (i < alphabets.Length)
            {
                if(!str.Contains(alphabets[i]))
                {
                    Console.WriteLine("NO");
                    return;
                }

                i++;
            }

            Console.WriteLine("YES");
        }
    }
}
