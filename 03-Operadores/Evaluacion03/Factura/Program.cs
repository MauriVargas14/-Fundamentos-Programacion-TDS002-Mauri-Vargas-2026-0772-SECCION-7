using System;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;

        Console.Write("Producto: ");
        string producto = Console.ReadLine();

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        double subtotal = cantidad * precio;
        double impuesto = subtotal * ITBIS;
        double total = subtotal + impuesto;

        Console.WriteLine("\nFACTURA");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Producto : {producto}");
        Console.WriteLine($"Cantidad : {cantidad}");
        Console.WriteLine($"Subtotal : {subtotal,10:N2}");
        Console.WriteLine($"ITBIS    : {impuesto,10:N2}");
        Console.WriteLine($"Total    : {total,10:N2}");
    }
}