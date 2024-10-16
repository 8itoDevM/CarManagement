﻿using System;

public class Program
{
    public static String GetCarInfo(Car car)
    {
        return $"Model: {car.Model}, Brand: {car.Brand}, Year: {car.Year}, Engine: {car.Engine}, Engine On?: {car.IsEngineOn()}, Price: {car.Price}, Distance Drove: {car.Usage} kilometer";
    }

    public static void CarConstructor()
    {

    }

    public static void TurnOn()
    {
        Console.Clear();

        selectedCar.StartEngine();
    }

    public static bool CarSelected()
    {
        if (selectedCar != null)
        {
            return true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("No car selected");
            return false;
        }
    }

    public static void CarDrvive()
    {
        Console.Clear();
        int dist = 0;

        Console.Write("Inform the distance to drive (km): ");
        dist = Convert.ToInt32(Console.ReadLine());

        selectedCar.Drive(dist);
    }

    public static void SelectCar()
    {
        int i = -1;
        Console.Clear();

        ListCars();

        Console.WriteLine("");

        Console.Write("Type the index of the car: ");
        i = Convert.ToInt32(Console.ReadLine());

        if (carList[i-1] != null)
        {
            selectedCar = carList[i-1];
            Console.WriteLine($"{selectedCar.Model} selected!");
        }
        else
        {
            Console.Write("Invalid option");
        }

        Console.ReadLine();
    }

    public static void ListCars()
    {
        Console.WriteLine("Listing all cars");
        for (int i = 0; i < carList.Count; i++)
        {
            Car car = carList[i];
            Console.WriteLine($"Car {i + 1}: {car.Model}");
        }
    }

    public static int Menu()
    {
        Console.Clear();
        int i = -1;

        
        if (CarSelected())
        {
            Console.WriteLine($"{selectedCar.Brand} {selectedCar.Model} selected");
        }

        Console.WriteLine(" ");

        Console.WriteLine("1 - Select car");
        Console.WriteLine("2 - Turn the car on");
        Console.WriteLine("3 - Drive car");
        Console.WriteLine("4 - Build car");
        Console.WriteLine("5 - Car info");
        Console.WriteLine("0 - Quit");

        return i = Convert.ToInt32(Console.ReadLine());
    }

    static PerformanceEngine perfEngine = new PerformanceEngine();
    static StandardEngine stnEngine = new StandardEngine();

    static Car f1 = new Car("F1", "Ferrari", 2017, perfEngine, 12200000, 0);
    static Car civic = new Car("Civic", "Honda", 2013, stnEngine, 80000, 1);

    public static List<Car> carList = new List<Car>();

    static Car selectedCar;

    static bool running = true;

    public static void Main(string[] args)
    {
        // remove this shit later
        carList.Add(f1);
        carList.Add(civic);

        while (running)
        {
            switch (Menu())
            {
                case 0:
                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    running = false;
                    break;
                case 1:
                    SelectCar();

                    break;
                case 2:

                    if (CarSelected())
                    {
                        TurnOn();
                    }

                    Console.ReadLine();
                    break;
                case 3:
                    if (CarSelected())
                    {
                        CarDrvive();
                    }

                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();

                    if (CarSelected())
                    {
                        Console.WriteLine(GetCarInfo(selectedCar));
                    }
                    Console.ReadLine();
                    break;
            }
        }
    }
}