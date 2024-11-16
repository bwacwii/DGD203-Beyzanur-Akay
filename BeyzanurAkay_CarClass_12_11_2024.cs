// See https://aka.ms/new-console-template for more information
namespace CarGame;
using System;
internal class Car
{
    public float Fuel { get; private set; }
    public float Torque { get; private set; }

    public int WheelCount;

    public string FuelType;

    public string CarType;

    public float Speed;

    public string CarColour;

    public int SeatCount;

    public string SeatColour;


    public Car(float fuel)
    {
        Fuel = Math.Clamp(fuel, 0f, 100f);
        if (fuel < 0) fuel = 0;
        Fuel = fuel;

        Torque = 200f;
        WheelCount = 4;
        FuelType = "motorin";
        CarType = "otomatic" ;
        Speed = 0f;
        CarColour = "red";
        SeatCount = 4;
        SeatColour = "black";
    }
    


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's talk about your dream car!");

           
            string userColor;
       
            while (true)
            {
                Console.WriteLine("Whats your dream car colour? (White,Red,Black)");
                userColor = Console.ReadLine()?.ToLower(); 

                if (userColor == "white" || userColor == "red" || userColor == "black")
                {
                    
                    if (userColor == "red")
                    {
                        Console.WriteLine("My car is red too, I think it's pretty cool!");
                    }
                    else
                    {                    
                        Console.WriteLine("Cool choices, but my choice is red.");
                    }
                    break;  
                }
                else
                {
                    
                    Console.WriteLine("Please choose from white, red and black only.");
                }
            }
            
            while (true)
            {
                Console.WriteLine("How many seats does your dream car have?");
                string userSeats = Console.ReadLine();

                if (int.TryParse(userSeats, out int seatCount))
                {
                    if (seatCount < 4)
                    {
                        Console.WriteLine("I guess your car is a bit small. hihi");
                    }
                    else if (seatCount == 4 || seatCount == 5)
                    {
                        Console.WriteLine("A very sufficient number of seats!");
                    }
                    else if (seatCount > 5)
                    {
                        Console.WriteLine("Are we sure it's the car you've been dreaming of?");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }


            string userFuel;
            while (true)
            {
                Console.WriteLine("What is the fuel type of your dream car? (Gasoline, Diesel, Electric, LPG)");
                userFuel = Console.ReadLine()?.ToLower();

                if (userFuel == "gasoline" || userFuel == "diesel" || userFuel == "electric" || userFuel == "lpg")
                {
                    if (userFuel == "electric")
                    {
                        Console.WriteLine("Sounds cool, so does mine!");
                    }
                    else
                    {
                        Console.WriteLine("Nicee!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("I'm talking about a car with an engine :D Can you please tell me your dream fuel type?");
                }
            }
            Console.WriteLine("Thanks for tring to my little interactive car game:)");
        }
    }
}



