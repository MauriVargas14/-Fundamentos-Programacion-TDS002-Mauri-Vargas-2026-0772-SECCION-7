using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");

        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;

            case 2:
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;

            case 3:
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;

            case 4:
                if (num2 != 0)
                    Console.WriteLine($"Resultado: {num1 / num2}");
                else
                    Console.WriteLine("No se puede dividir entre cero.");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}