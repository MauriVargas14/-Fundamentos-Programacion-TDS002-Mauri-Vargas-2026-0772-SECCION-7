using System;

class Program
{
    static void Main(string[] args)
    {
        const double tasaUsd = 60.00;

        Console.Write("Monto en pesos: ");
        double pesos = double.Parse(Console.ReadLine());

        double dolares = pesos / tasaUsd;

        Console.WriteLine($"RD$ {pesos} = US$ {dolares:F2}");
    }
}