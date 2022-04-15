using System;
using Assignments;

namespace ABC
{
    class Program
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Sum: " + Assignment.NumbersMethod(2, 2, 3, 4, 6).sum);
            Console.WriteLine("AVG: " + Assignment.NumbersMethod(2, 2, 3, 4, 6).avg);


        }

    }
}