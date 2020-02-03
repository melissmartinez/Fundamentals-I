using System;

namespace Fundamental_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //a loop that prints all numbers from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }



            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 ==0 && j % 5 == 0)
                {
                    continue;
                }
                else if (j % 3 == 0 || j % 5 == 0)
                {
                    Console.WriteLine(j);
                }
            }



            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

        }
    }
}
