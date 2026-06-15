/*
 * EJERCICIO: Números Primos
 * DESCRIPCIÓN: Identificar y mostrar números primos
 * CONCEPTOS: for loop, lógica de primalidad
 */

using System;

class NumerosPrimos
{
    static void Main()
    {
        // Mostrar números primos hasta 50
        Console.WriteLine("=== Números primos hasta 50 ===");
        for (int i = 2; i <= 50; i++)
        {
            if (EsPrimo(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // Verificar si un número específico es primo
        Console.WriteLine("\n=== Verificar si un número es primo ===");
        int numero = 17;
        if (EsPrimo(numero))
        {
            Console.WriteLine($"{numero} SÍ es un número primo");
        }
        else
        {
            Console.WriteLine($"{numero} NO es un número primo");
        }

        // Contar primos
        Console.WriteLine("\n=== Cantidad de números primos hasta 100 ===");
        int contador = 0;
        for (int i = 2; i <= 100; i++)
        {
            if (EsPrimo(i))
            {
                contador++;
            }
        }
        Console.WriteLine($"Hay {contador} números primos entre 2 y 100");
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
}
