int numero;

do
{
    Console.Write("Ingrese un número del 1 al 12: ");
}
while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 12);

int contador = 1;
int suma = 0;

while (contador <= 12)
{
    int resultado = numero * contador;

    Console.WriteLine($"{numero} x {contador} = {resultado}");

    suma += resultado;
    contador++;
}

Console.WriteLine($"Suma total: {suma}");