using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private string brand;
    private int year;
    private double price;
    private int usage = 0;
    private IEngine engine;
    private int carId;

    public Car(string model, string brand, int year, IEngine engine, double price, int carId)
    {
        this.model = model;
        this.brand = brand;
        this.year = year;
        this.engine = engine;
        this.price = price;
        this.carId = carId;
        usage = usage;
    }

    public int Usage
    {
        get { return usage; }
    }

    public int CarId
    {
        get { return carId; }
        set { carId = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public IEngine Engine => engine;

    public void StartEngine()
    {
        Engine.TurnOn();
    }

    public void StopEngine()
    {
        Engine.TurnOff();
    }

    public void Drive(int dist)
    {
        if (Engine.IsOn())
        {
            Console.WriteLine($"{model} drove {dist} kilometers");
            usage += dist;
            Devalue(dist);
        }
        else
        {
            Console.WriteLine("The car is turned off");
        }
    }

    void Devalue(int dist)
    {
        price = price - (0.2 * dist);
    }

    public bool IsEngineOn()
    {
        return Engine.IsOn();
    }
}
