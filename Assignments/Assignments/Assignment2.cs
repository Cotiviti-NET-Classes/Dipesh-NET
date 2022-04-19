using System;

namespace Assignments;

// Base Class 1 which cannot be instantiated.
public abstract class Car
{
    // private Car() { }
    public string name;
    public void display()
    {
        Console.WriteLine($"Hello from Car: {name}");
    }
}

//Child Class 1: Inherits Base class 1- Car with Interface 1- ICharge.
public class ElectricVehicle : Car, ICharge
{
    public int voltage;

    //Overriding the Parent method: Display()
    public void display()
    {
        Console.WriteLine($"Hello, I am EV Car: {name}, Voltage: {voltage}");
    }

    public void Charge()
    {
        Console.WriteLine("Hello, I am Charging.");
    }
}

//Grand Child which inherits Child Class 1- ElectricVehicle and It is protected from being inherited.
public sealed class Hummer : ElectricVehicle
{
    public double mileage;
}


/********* -Running this wil show build error as Hummer is sealed and can't be inherited- ***********/
// public class Check : Hummer
// {
//     public checkMethod()
//     {
//         Console.WriteLine("Hello from check");
//     }
// }

//Base Class 2.
public class Bike
{
    public string name;
    public void display()
    {
        Console.WriteLine($"Hello from Bike: {name}");
    }
}

//Child Class 2: Inherits Base Class 2- Bike with Interface 1- ICharge and Interface 2- ISound.
public class ElectricBike : Bike, ICharge, ISound
{
    //overriding parent class property: name.
    public string name;
    public string model;
    public double mileage;

    public void Charge()
    {
        Console.WriteLine("I am Charging.");
    }
    public void Sound()
    {
        Console.WriteLine("Vroom, Suiiiiiiiiiiii, Without smoke.");
    }
}

//Child Class 3: Inherits Base Class 2- Bike with Interface 2- ISound.
public class PetrolBike : Bike, ISound
{
    public string model;
    public double mileage;

    //overriding the parent method: Display()
    public void display()
    {
        //implementation of parent method: Display().
        base.display();
        Console.WriteLine($"Hello I am Petrol Version, Model: {model}, Mileage: {mileage}");
    }

    public void Sound()
    {
        Console.WriteLine("Vroom Vrooooooom with smoke.");
    }
}

//Interface 1.
public interface ICharge
{
    void Charge();
}


//Interface 2.
public interface ISound
{
    void Sound();
}

