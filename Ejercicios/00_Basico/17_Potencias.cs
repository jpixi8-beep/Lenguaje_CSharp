/*
 * EJERCICIO: Calcular Potencias
 * DESCRIPCIÓN: Calcular un número elevado a una potencia
 * CONCEPTOS: Math.Pow(), operadores
 */

using System;

class Potencias
{
    static void Main()
    {
        // Calcular potencias
        double baseNum = 2;
        double exponente = 3;
        double resultado = Math.Pow(baseNum, exponente);

        Console.WriteLine($"{baseNum}^{exponente} = {resultado}");

        // Probar con más números
        Console.WriteLine("\n=== Tabla de potencias de 2 ===");
        for (int i = 0; i <= 10; i++)
        {
            double pot = Math.Pow(2, i);
            Console.WriteLine($"2^{i} = {pot}");
        }

        // Tabla de potencias personalizada
        Console.WriteLine("\n=== Potencias del 5 ===");
        baseNum = 5;
        for (int i = 1; i <= 5; i++)
        {
            double pot = Math.Pow(baseNum, i);
            Console.WriteLine($"{baseNum}^{i} = {pot}");
        }
    }
}
