/*
 * EJERCICIO: Valor Absoluto
 * DESCRIPCIÓN: Obtener el valor positivo de un número
 * CONCEPTOS: Math.Abs()
 */

using System;

class ValorAbsoluto
{
    static void Main()
    {
        // Calcular valor absoluto
        int numero1 = -15;
        int valorAbs1 = Math.Abs(numero1);
        Console.WriteLine($"Valor absoluto de {numero1} es: {valorAbs1}");

        double numero2 = -3.5;
        double valorAbs2 = Math.Abs(numero2);
        Console.WriteLine($"Valor absoluto de {numero2} es: {valorAbs2}");

        // Aplicación: Calcular distancia entre dos números
        Console.WriteLine("\n=== Distancia entre números ===");
        int num1 = 5;
        int num2 = -10;
        int distancia = Math.Abs(num1 - num2);
        Console.WriteLine($"Distancia entre {num1} y {num2} es: {distancia}");

        // Tabla de valores absolutos
        Console.WriteLine("\n=== Valores absolutos ===");
        int[] numeros = { -10, -5, 0, 5, 10, -20 };
        foreach (int num in numeros)
        {
            Console.WriteLine($"|{num}| = {Math.Abs(num)}");
        }
    }
}
