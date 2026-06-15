/*
 * EJERCICIO: Suma de Números
 * DESCRIPCIÓN: Sumar números consecutivos desde 1 hasta n
 * CONCEPTOS: do-while loop, acumuladores
 */

using System;

class SumaDeNumeros
{
    static void Main()
    {
        int n = 10;

        // Forma 1: Usando do-while
        Console.WriteLine("=== Suma usando do-while ===");
        int suma = 0;
        int contador = 1;
        do
        {
            suma += contador;
            contador++;
        } while (contador <= n);
        Console.WriteLine($"Suma de 1 a {n} = {suma}");

        // Forma 2: Usando fórmula matemática
        Console.WriteLine("\n=== Suma usando fórmula ===");
        int sumaFormula = (n * (n + 1)) / 2;
        Console.WriteLine($"Suma de 1 a {n} = {sumaFormula}");

        // Tabla de sumas acumulativas
        Console.WriteLine("\n=== Tabla de sumas acumulativas ===");
        suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
            Console.WriteLine($"Suma de 1 a {i} = {suma}");
        }
    }
}
