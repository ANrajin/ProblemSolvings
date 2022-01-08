using System;
using System.Linq;
using System.Text;

namespace CF_1352A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                t--;
                int k = 1;
                StringBuilder _result = new StringBuilder();
                double n = double.Parse(Console.ReadLine());

                if(n < 10 || (n/10) % 10 == 0)
                {
                    Console.Write($"{k}\n{n}\n");
                }
                else
                {
                    var l = Math.Floor(Math.Log10(n));
                    double[] arr = n.ToString().Select(s => Convert.ToDouble(s.ToString())).ToArray();
                    for (var i = 0; i < arr.Length; i++)
                    {
                        var d = arr[int.Parse(i.ToString())];

                        if ((n / 10) % 10 != 0 && d > 0)
                        {
                            var substract = Math.Pow(10, l) * d;
                            n -= substract; k++;
                            _result.Append($"{substract} ");
                        }

                        l--;
                    }

                    Console.Write($"{--k}\n{_result}\n");
                }
            }
        }
    }
}
