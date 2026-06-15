/*
 * EJERCICIO: Números Impares
 * DESCRIPCIÓN: Mostrar todos los números impares en un rango
 * CONCEPTOS: do-while loop, condicionales
 */

using System;

class NumerosImpares
{
    static void Main()
    {
        // Forma 1: Usando do-while
        Console.WriteLine("=== Números impares del 1 al 20 (do-while) ===");
        int numero = 1;
        do
        {
            if (numero % 2 != 0)
            {
                Console.Write(numero + " ");
            }
            numero++;
        } while (numero <= 20);
        Console.WriteLine();

        // Forma 2: Usando for con incremento de 2
        Console.WriteLine("\n=== Números impares del 1 al 20 (for) ===");
        for (int i = 1; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Contar números impares
        Console.WriteLine("\n=== Conteo de números impares ===");
        int contador = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                contador++;
            }
        }
        Console.WriteLine($"Hay {contador} números impares entre 1 y 100");

        // Suma de números impares
        Console.WriteLine("\n=== Suma de números impares ===");
        int suma = 0;
        for (int i = 1; i <= 50; i += 2)
        {
            suma += i;
        }
        Console.WriteLine($"Suma de números impares del 1 al 50 = {suma}");
    }
}
