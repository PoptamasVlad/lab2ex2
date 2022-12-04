using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa factorialul unui numar n, n fiind citit
            de la tastatura. */

            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            if(n == 0)
            {
                Console.WriteLine(factorial);
                return;
            }
            for(int i=1; i<=n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
