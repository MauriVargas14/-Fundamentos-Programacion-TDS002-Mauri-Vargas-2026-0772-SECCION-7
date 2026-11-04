using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número entero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int numero2 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int producto = numero1 * numero2;
        double divisionReal = (double)numero1 / numero2;
        int divisionEntera = numero1 / numero2;
        int residuo = numero1 % numero2;
        bool esPar = numero1 % 2 == 0;

        Console.WriteLine($"\nSuma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"División real: {divisionReal}");
        Console.WriteLine($"División entera: {divisionEntera}");
        Console.WriteLine($"Residuo: {residuo}");
        Console.WriteLine($"¿El primer número es par?: {esPar}");
    }
}

/*
Prueba de escritorio
x = 10
y = 3

Suma = 13
Resta = 7
Producto = 30
División real = 3.3333333
División entera = 3
Residuo = 1
¿Es par? = true
*/