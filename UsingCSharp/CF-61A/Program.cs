using System;
using System.Text;

namespace CF_61A
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            StringBuilder _result = new StringBuilder();

            for(var i = 0; i < n1.Length; i++)
            {
                if (n1[i] == n2[i])
                    _result.Append("0");
                else
                    _result.Append("1");
            }

            Console.WriteLine(_result.ToString());
        }
    }
}
