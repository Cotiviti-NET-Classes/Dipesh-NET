using System;

namespace Assignments;

class PetrolMotorBike
{
    public PetrolMotorBike()
    {
        fuelType = "Petrol";
    }

    public PetrolMotorBike(string name, string color)
    {
        fuelType = "Petrol";

        this.Name = name;
        this.Color = color;

        if (color.ToUpper() == "PINK" || color.ToUpper() == "RED")
        {
            this.ColorChoice = "Girls";
        }
        else
        {
            this.ColorChoice = "Boys";
        }
    }

    public string? Name { get; set; }
    public string? Color { get; set; }

    //constant that runtine instance can modify.
    public readonly string? fuelType;

    //read-only property.
    public string? ColorChoice { get; private set; }

    //constant that can be changed at compile time.
    private const int FuelTankCapacity = 10;
    //write-only property
    private string? _servicingNumber;

    //Write-only Property
    public string ServicingNumber
    {
        set { _servicingNumber = value; }
    }

    enum Brakes
    {
        Front,
        Back
    }

    public (string? name, string? color) Display()
    {
        string? name = this.Name;
        string? color = this.Color;
        // Console.WriteLine($"Bike: {this.Name}, Color: {this.Color}");
        return (name, color);
    }


}