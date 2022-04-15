using System;
using Assignments;

namespace ABC
{
    class Program
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            // Console.WriteLine("Hello, World!");

            //Defining array
            int[] array = { 2, 2, 3, 4, 6 };
            var withParams = Assignment.NumbersMethodParam(2, 2, 3, 4, 6);
            var withArrays = Assignment.NumbersMethodArray(array);

            //Display SUM and AVG Using Multiple Params: 
            Console.WriteLine("Using Multiple Params");
            Console.WriteLine("Sum: " + withParams.sum + " AVG: " + withParams.avg);

            //Display SUM and AVG using Array;
            Console.WriteLine("Using Arrays");
            Console.WriteLine("SUM: " + withArrays.sum + " AVG: " + withArrays.avg);


        }

    }
}