/*
 * EJERCICIO: Serie Ascendente
 * DESCRIPCIÓN: Mostrar números en orden ascendente usando while
 * CONCEPTOS: while loop
 */

using System;

class SerieAscendente
{
    static void Main()
    {
        // Forma 1: Usando while
        Console.WriteLine("=== Serie Ascendente (while) ===");
        int numero = 1;
        while (numero <= 10)
        {
            Console.Write(numero + " ");
            numero++;
        }
        Console.WriteLine();

        // Forma 2: Usando for
        Console.WriteLine("\n=== Serie Ascendente (for) ===");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Forma 3: Números pares
        Console.WriteLine("\n=== Serie de números pares ===");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Forma 4: Con saltos personalizados
        Console.WriteLine("\n=== Serie con saltos de 5 ===");
        for (int i = 0; i <= 50; i += 5)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
