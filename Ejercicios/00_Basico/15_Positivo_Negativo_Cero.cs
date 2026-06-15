/*
 * EJERCICIO: Determinar si un número es Positivo, Negativo o Cero
 * DESCRIPCIÓN: Clasificar números según su valor
 * CONCEPTOS: if-else if-else
 */

using System;

class PositivoNegativoCero
{
    static void Main()
    {
        int numero = -5;

        ClasificarNumero(numero);

        // Probar con más números
        Console.WriteLine("\n=== Probando varios números ===");
        int[] numeros = { 10, -3, 0, 25, -15, 1 };

        foreach (int num in numeros)
        {
            ClasificarNumero(num);
        }
    }

    static void ClasificarNumero(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"{num} es POSITIVO");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} es NEGATIVO");
        }
        else
        {
            Console.WriteLine($"{num} es CERO");
        }
    }
}
