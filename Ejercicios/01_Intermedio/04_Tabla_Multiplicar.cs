/*
 * EJERCICIO: Tabla de Multiplicar
 * DESCRIPCIÓN: Mostrar la tabla de multiplicación de un número
 * CONCEPTOS: for loop, multiplicación
 */

using System;

class TablaMultiplicar
{
    static void Main()
    {
        int numero = 7;

        // Tabla simple
        Console.WriteLine($"=== Tabla de multiplicar del {numero} ===");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        // Tabla de dos dígitos
        Console.WriteLine($"\n=== Tabla extendida del {numero} (1-20) ===");
        for (int i = 1; i <= 20; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero:D2} x {i:D2} = {resultado:D4}");
        }

        // Todas las tablas del 1 al 10
        Console.WriteLine("\n=== Todas las tablas del 1 al 10 ===");
        for (int num = 1; num <= 10; num++)
        {
            Console.WriteLine($"\nTabla del {num}:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{num}x{i}={num * i}  ");
            }
            Console.WriteLine();
        }
    }
}
