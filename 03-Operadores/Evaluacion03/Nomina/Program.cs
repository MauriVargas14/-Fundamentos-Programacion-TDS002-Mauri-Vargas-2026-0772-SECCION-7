using System;

class Program
{
    static void Main(string[] args)
    {
        const double AFP = 0.0287;
        const double SFS = 0.0304;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine());

        Console.Write("Pago por hora: ");
        double pagoHora = double.Parse(Console.ReadLine());

        double salarioBruto = horas * pagoHora;
        double descuentoAfp = salarioBruto * AFP;
        double descuentoSfs = salarioBruto * SFS;
        double salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

        Console.WriteLine($"\nEMPLEADO: {nombre.ToUpper()}");
        Console.WriteLine($"Salario Bruto: {salarioBruto:N2}");
        Console.WriteLine($"AFP: {descuentoAfp:N2}");
        Console.WriteLine($"SFS: {descuentoSfs:N2}");
        Console.WriteLine($"Salario Neto: {salarioNeto:N2}");
    }
}