using System;

namespace CF_703A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int mi = default;
            int ci = default;

            for(var i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();

                int ai = int.Parse(str[0]);
                int bi = int.Parse(str[1]);

                if (ai > bi)
                    mi++;
                if (ai < bi)
                    ci++;
            }

            if(mi > ci)
                Console.WriteLine("Mishka");
            else if(mi == ci)
                Console.WriteLine("Friendship is magic!^^");
            else
                Console.WriteLine("Chris");
        }
    }
}
