// See https://aka.ms/new-console-template for more information
namespace CarGame;

public class Car
{
    public float Fuel { get; private set; }
    public float Torque { get; private set; }

    public int WheelCount;

    public string FuelType;

    public string CarType;

    public float Speed;

    public Car(float fuel)
    {
        Fuel = Math.Clamp(fuel, 0f, 100f);
        if (fuel < 0) fuel = 0;
        Fuel = fuel;

        Torque = 200f;
        WheelCount = 4;
        FuelType = "Diesel";
        CarType = "manual" ;
        Speed = 0f;
    }

  
}

    






