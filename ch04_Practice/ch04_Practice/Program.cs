using System;

namespace ch04_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5.9;
            decimal dec = 4.333m;
            int pop = 1_734_323;
            double starCount = 3.65e+2;
            string hello = "Hello " + d + "\n" + "I owe " + pop + " dollars to my wife";
            const double AnnInterest = 4.2;

            int x = 12;
            int y = 5;

            int result = -x;

            int product = result * y;

            int play = x++;

            int divide = x % y;
            // playing around with console statements
            Console.WriteLine(dec);
            Console.WriteLine(d);
            Console.WriteLine(pop);
            Console.WriteLine(starCount);
            Console.WriteLine(hello);
            Console.WriteLine(AnnInterest);
            Console.WriteLine(result);
            Console.WriteLine(product);
            Console.WriteLine(play);
            Console.WriteLine(divide);
        }
    }
}
