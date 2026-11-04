using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una nota (0-100): ");

        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            if (nota >= 90 && nota <= 100)
                Console.WriteLine("Calificación: A");
            else if (nota >= 80)
                Console.WriteLine("Calificación: B");
            else if (nota >= 70)
                Console.WriteLine("Calificación: C");
            else if (nota >= 0)
                Console.WriteLine("Calificación: F");
            else
                Console.WriteLine("Nota inválida.");
        }
        else
        {
            Console.WriteLine("Debe ingresar un número válido.");
        }
    }
}