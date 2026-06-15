/*
 * EJERCICIO: Calcular Factorial
 * DESCRIPCIÓN: Calcular el factorial de un número (n!)
 * CONCEPTOS: do-while loop, multiplicación acumulativa
 */

using System;

class Factorial
{
    static void Main()
    {
        int numero = 5;

        // Forma 1: Usando do-while
        Console.WriteLine("=== Factorial usando do-while ===");
        int factorial = 1;
        int contador = 1;
        do
        {
            factorial *= contador;
            contador++;
        } while (contador <= numero);
        Console.WriteLine($"Factorial de {numero} = {factorial}");

        // Forma 2: Usando for
        Console.WriteLine("\n=== Factorial usando for ===");
        factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Factorial de {numero} = {factorial}");

        // Tabla de factoriales
        Console.WriteLine("\n=== Tabla de factoriales ===");
        for (int n = 1; n <= 10; n++)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"{n}! = {fact}");
        }
    }
}
