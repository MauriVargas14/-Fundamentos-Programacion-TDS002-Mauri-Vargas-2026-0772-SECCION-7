int secreto = Random.Shared.Next(1, 101);
int numero;
int intentos = 0;

do
{
    Console.Write("Adivina el número (1-100): ");
    int.TryParse(Console.ReadLine(), out numero);

    intentos++;

    if (numero < secreto)
        Console.WriteLine("Mayor");
    else if (numero > secreto)
        Console.WriteLine("Menor");

} while (numero != secreto);

Console.WriteLine($"¡Correcto! Intentos: {intentos}");