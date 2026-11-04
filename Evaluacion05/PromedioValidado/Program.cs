double suma = 0;
int cantidad = 0;
double mayor = 0;
double menor = 100;
double nota;

do
{
    Console.Write("Nota (0-100, -1 para terminar): ");

    if (!double.TryParse(Console.ReadLine(), out nota))
        continue;

    if (nota == -1)
        break;

    if (nota >= 0 && nota <= 100)
    {
        suma += nota;
        cantidad++;

        if (nota > mayor)
            mayor = nota;

        if (nota < menor)
            menor = nota;
    }

} while (true);

if (cantidad > 0)
{
    Console.WriteLine($"\nPromedio: {suma / cantidad:N2}");
    Console.WriteLine($"Mayor: {mayor}");
    Console.WriteLine($"Menor: {menor}");
}
else
{
    Console.WriteLine("No se ingresaron notas.");
}