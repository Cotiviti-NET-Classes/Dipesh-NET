using System;

namespace Assignments;

// Base Class 1.
public class Car
{
    // private Car() { }
    public string name;
    public void Display()
    {
        Console.WriteLine("Hello from Car.");
    }
}

//Child Class 1: Inherits Base class 1- Car with Interface 1- ICharge.
public class ElectricVehicle : Car, ICharge
{
    public int voltage;

    //Overriding the Parent method: Display()
    public void Display()
    {
        Console.WriteLine("Hello, I am EV Car.");
    }

    public void Charge()
    {
        Console.WriteLine("Hello, I am Charging.");
    }
}

//Grand Child which inherits Child Class 1- ElectricVehicle
public class Hummer : ElectricVehicle
{
    public double mileage;
}

//Base Class 2.
public class Bike
{
    public string name;
    public void Display()
    {
        Console.WriteLine("Hello from Bike.");
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
    public void Display()
    {
        //implementation of parent method: Display().
        base.Display();
        Console.WriteLine("Hello I am Petrol Version");
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

