using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número decimal: ");
        double numeroDecimal = double.Parse(Console.ReadLine());

        int parteEntera = (int)numeroDecimal;
        double numeroConvertido = parteEntera;

        Console.WriteLine($"Número original: {numeroDecimal}");
        Console.WriteLine($"Parte entera: {parteEntera}");
        Console.WriteLine($"Conversión implícita a double: {numeroConvertido}");
    }
}