using System;

using Assignments;

namespace ABC
{
    class Program
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information

            /********** Displaying Hello World. **********/

            // Console.WriteLine("Hello, World!");


            /********** Displaying Assignment 1. **********/

            // // Defining array
            // int[] array = { 2, 2, 3, 4, 6 };
            // var withParams = Assignment.NumbersMethodParam(2, 2, 3, 4, 6);
            // var withArrays = Assignment.NumbersMethodArray(array);

            // //Display SUM and AVG Using Multiple Params: 
            // Console.WriteLine("Using Multiple Params");
            // Console.WriteLine("Sum: " + withParams.sum + " AVG: " + withParams.avg);

            // //Display SUM and AVG using Array;
            // Console.WriteLine("Using Arrays");
            // Console.WriteLine("SUM: " + withArrays.sum + " AVG: " + withArrays.avg);


            /********** Displaying Assignment 2. **********/

            //Trying to Instantiate Car class gives error as it is abstract class
            // Car car = new();

            //Grand Child.
            // Console.WriteLine("--------- Grand Child ---------");
            // Hummer hummer = new()
            // {
            //     name = "HummerEV",
            //     voltage = 250,
            //     mileage = 30.24,
            // };
            // hummer.display();
            // hummer.Charge();
            // Console.WriteLine("");

            // Console.WriteLine("--------- Child 2, with 2 Interface ---------");
            // ElectricBike electricBike = new()
            // {
            //     name = "TVS",
            //     model = "iQube Electric",
            //     mileage = 50.23,
            // };
            // electricBike.Charge();
            // electricBike.Sound();
            // Console.WriteLine("");

            // Console.WriteLine("--------- Child 3, with 1 interface ---------");
            // PetrolBike petrolBike = new()
            // {
            //     name = "Yamaha",
            //     model = "FZ",
            //     mileage = 20.5,
            // };
            // petrolBike.display();
            // petrolBike.Sound();
            // Console.WriteLine("");


            /********** Displaying Assignment 3. **********/

            // PetrolMotorBike value = new()
            // {
            //     Name = "Yamaha",
            //     Color = "Blue",
            // };

            // PetrolMotorBike value = new PetrolMotorBike("Yamaha", "Red");

            // Console.WriteLine($"Name: {value.Display().name} , Color: {value.Display().color}");
            // Console.WriteLine($"Fuel: {value.fuelType}");
            // Console.WriteLine($"Choice: {value.ColorChoice}");


            /********** Displaying Assignment 4. **********/

            FileHandle var = new();
            var.data();

        }

    }
}



