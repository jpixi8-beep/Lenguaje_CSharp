/*
 * EJERCICIO: Secuencia Fibonacci
 * DESCRIPCIÓN: Generar la serie Fibonacci hasta n términos
 * CONCEPTOS: for loop, suma acumulativa de múltiples variables
 */

using System;

class Fibonacci
{
    static void Main()
    {
        int terminos = 10;

        Console.WriteLine($"=== Secuencia Fibonacci ({terminos} términos) ===");

        int numero1 = 0;
        int numero2 = 1;

        Console.Write($"{numero1} ");

        for (int i = 1; i < terminos; i++)
        {
            Console.Write($"{numero2} ");
            
            // Calcular siguiente término
            int siguiente = numero1 + numero2;
            numero1 = numero2;
            numero2 = siguiente;
        }
        Console.WriteLine();

        // Fibonacci con tabla
        Console.WriteLine($"\n=== Fibonacci con posiciones ===");
        numero1 = 0;
        numero2 = 1;
        Console.WriteLine($"F(0) = {numero1}");
        Console.WriteLine($"F(1) = {numero2}");

        for (int i = 2; i <= terminos; i++)
        {
            int siguiente = numero1 + numero2;
            Console.WriteLine($"F({i}) = {siguiente}");
            numero1 = numero2;
            numero2 = siguiente;
        }
    }
}
