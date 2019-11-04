using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double i, x = 0;


            for (i = -21; i <= -5; i++)
            {
                sum += i;
                x++;
            }
            Console.WriteLine(sum / x);

        }
    }
}