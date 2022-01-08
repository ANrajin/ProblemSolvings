using System;
using System.Text;

namespace CF_705A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder _result = new StringBuilder();

            for(var i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                    _result.Append("I love ");
                else
                    _result.Append("I hate ");

                if(i == n)
                    _result.Append("it");
                else
                    _result.Append("that ");
            }

            Console.WriteLine(_result.ToString());
        }
    }
}
