using System;

class Program
{
    static void Main(string[] args)
    {
        const int anioActual = 2026;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Estatura: ");
        double estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Trabaja? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine());

        int anioCumple30 = anioActual + (30 - edad);

        Console.WriteLine($"\nNombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Estatura: {estatura}");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en: {anioCumple30}");
    }
}