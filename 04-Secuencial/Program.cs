using System;

class Program
{
    static void Main(string[] args)
    {
        const double librasAKg = 0.453592;

        Console.Write("Ingrese el peso en libras: ");
        double libras = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la temperatura en °F: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double kilogramos = libras * librasAKg;
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"\nPeso en kilogramos: {kilogramos:F2} kg");
        Console.WriteLine($"Temperatura en Celsius: {celsius:F2} °C");
    }
}