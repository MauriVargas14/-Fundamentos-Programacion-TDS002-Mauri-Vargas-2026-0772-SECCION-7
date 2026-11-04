int cantidad = 0;
double subtotal = 0;
double precio;

do
{
    Console.Write("Precio (0 para terminar): ");

    if (double.TryParse(Console.ReadLine(), out precio))
    {
        if (precio > 0)
        {
            subtotal += precio;
            cantidad++;
        }
    }

} while (precio != 0);

double itbis = subtotal * 0.18;
double total = subtotal + itbis;

Console.WriteLine($"\nProductos: {cantidad}");
Console.WriteLine($"Subtotal: {subtotal:N2}");
Console.WriteLine($"ITBIS: {itbis:N2}");
Console.WriteLine($"Total: {total:N2}");