using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());

        Console.Write("Cateto A: ");
        double catetoA = double.Parse(Console.ReadLine());

        Console.Write("Cateto B: ");
        double catetoB = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        Console.WriteLine($"\nArea: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}