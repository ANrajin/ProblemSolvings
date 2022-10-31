using System;

namespace CF_58A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 58A : Chat room

            string s = Console.ReadLine().ToLower();

            string word = "hello";
            string _result = default;
            var check = false;

            for (var i = 0; i < word.Length; i++)
            {
                check = true;

                while (check && s.Length > 0)
                {
                    if (word[i].Equals(s[0]))
                    {
                        _result += s[0];
                        s = s.Remove(0, 1);
                        check = false;
                    }
                    else
                    {
                        s = s.Remove(0, 1);
                    }
                }

            }

            if (word.Equals(_result))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}