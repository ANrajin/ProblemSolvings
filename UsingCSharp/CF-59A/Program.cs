using System;

namespace CF_59A
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            string result = x.ToLower();

            int upperCaseLength = 0;
            int lowerCaseLength = 0;

            for (var i = 0; i < x.Length; i++)
            {
                if (x[i] == result[i])
                    lowerCaseLength += 1;
                else
                    upperCaseLength += 1;
            }

            if (upperCaseLength > lowerCaseLength)
                result = result.ToUpper();

            Console.WriteLine(result);
        }
    }
}