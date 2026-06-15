/*
 * EJERCICIO: Determinar si un número es Par o Impar
 * DESCRIPCIÓN: Usar el operador módulo para clasificar números
 * CONCEPTOS: Operador módulo (%), if-else
 */

using System;

class ParoImpar
{
    static void Main()
    {
        int numero = 7;

        // Usar módulo para determinar si es par o impar
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número PAR");
        }
        else
        {
            Console.WriteLine($"{numero} es un número IMPAR");
        }

        // Probar con más números
        Console.WriteLine("\n=== Probando varios números ===");
        for (int i = 1; i <= 10; i++)
        {
            string tipo = i % 2 == 0 ? "PAR" : "IMPAR";
            Console.WriteLine($"{i} es {tipo}");
        }
    }
}
