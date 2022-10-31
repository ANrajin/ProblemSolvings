using System;
using System.Linq;

namespace CF_114A
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            char[] str1 = Console.ReadLine().ToCharArray();
            char[] str2 = $"{a}{b}".ToCharArray();

            Array.Sort(str1);
            Array.Sort(str2);

            if(str1.Length == str2.Length)
            {
                for (var i = 0; i < str2.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
