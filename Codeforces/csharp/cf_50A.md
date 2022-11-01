# Domino piling


```
using System;

namespace CF_50A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split();

            int m = int.Parse(x[0]);
            int n = int.Parse(x[1]);

            int pile = 2 * 1;

            var result = Math.Abs((m * n) / pile);

            Console.WriteLine(result);
        }
    }
}
```
