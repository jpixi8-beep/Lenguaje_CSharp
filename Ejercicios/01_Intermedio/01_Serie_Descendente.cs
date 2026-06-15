/*
 * EJERCICIO: Serie Descendente
 * DESCRIPCIÓN: Mostrar números en orden descendente
 * CONCEPTOS: do-while loop, decremento
 */

using System;

class SerieDescendente
{
    static void Main()
    {
        // Forma 1: Usando do-while
        Console.WriteLine("=== Serie Descendente (do-while) ===");
        int numero = 10;
        do
        {
            Console.Write(numero + " ");
            numero--;
        } while (numero >= 1);
        Console.WriteLine();

        // Forma 2: Usando for inverso
        Console.WriteLine("\n=== Serie Descendente (for) ===");
        for (int i = 20; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Forma 3: Números pares descendentes
        Console.WriteLine("\n=== Números pares descendentes ===");
        for (int i = 20; i >= 0; i -= 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Forma 4: Números de 100 a 0 con saltos de 10
        Console.WriteLine("\n=== De 100 a 0 con saltos de 10 ===");
        for (int i = 100; i >= 0; i -= 10)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
