using System;

class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura: ");
        double estatura = double.Parse(Console.ReadLine());

        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine($"\nNombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
    }
}