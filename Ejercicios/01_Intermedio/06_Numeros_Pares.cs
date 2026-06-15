/*
 * EJERCICIO: Números Pares
 * DESCRIPCIÓN: Mostrar todos los números pares en un rango
 * CONCEPTOS: while loop, condicionales
 */

using System;

class NumerosPares
{
    static void Main()
    {
        // Forma 1: Usando while
        Console.WriteLine("=== Números pares del 1 al 20 (while) ===");
        int numero = 1;
        while (numero <= 20)
        {
            if (numero % 2 == 0)
            {
                Console.Write(numero + " ");
            }
            numero++;
        }
        Console.WriteLine();

        // Forma 2: Usando for con incremento de 2
        Console.WriteLine("\n=== Números pares del 1 al 20 (for) ===");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Contar números pares
        Console.WriteLine("\n=== Conteo de números pares ===");
        int contador = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                contador++;
            }
        }
        Console.WriteLine($"Hay {contador} números pares entre 1 y 100");

        // Suma de números pares
        Console.WriteLine("\n=== Suma de números pares ===");
        int suma = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }
        Console.WriteLine($"Suma de números pares del 1 al 50 = {suma}");
    }
}
