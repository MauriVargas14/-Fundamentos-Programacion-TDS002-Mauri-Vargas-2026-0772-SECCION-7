int opcion;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1. Tablas");
    Console.WriteLine("2. Triángulo");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }

            break;

        case 2:

            Console.Write("Cantidad de filas: ");
            int filas;
            int.TryParse(Console.ReadLine(), out filas);

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            break;

        case 0:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 0);