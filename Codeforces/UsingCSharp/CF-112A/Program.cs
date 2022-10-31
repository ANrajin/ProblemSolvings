using System;

namespace CF_112A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-112A: Petya and Strings
            string str1 = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();

            int result = 0;

            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] > str2[i])
                {
                    result = 1;
                    break;
                }
                else if (str1[i] < str2[i])
                {
                    result = -1;
                    break;
                }
                else
                {
                    result = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}
