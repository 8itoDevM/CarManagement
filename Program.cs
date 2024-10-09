using System;

public class Program
{
    static PerformanceEngine perfEngine = new PerformanceEngine();
    static StandardEngine stnEngine = new StandardEngine();

    static Car f1 = new Car("F1", "Ferrari", 2017, perfEngine, 12200000);
    static Car civic = new Car("Civic", "Honda", 2013, stnEngine, 80000);

    public static void Main(string[] args)
    {
        civic.StartEngine();
        Console.WriteLine(GetCarInfo(civic));
        civic.Drive(200000);
        Console.WriteLine(GetCarInfo(civic));

    }

    public static String GetCarInfo(Car car)
    {
        return $"Model: {car.Model}, Brand: {car.Brand}, Year: {car.Year}, Engine: {car.Engine}, Engine On?: {car.IsEngineOn()}, Price: {car.Price}, Distance Drove: {car.Usage}";
    }
}