/*
 * EJERCICIO: Calcular Raíz Cuadrada
 * DESCRIPCIÓN: Usar la librería Math para calcular raíces cuadradas
 * CONCEPTOS: Math.Sqrt()
 */

using System;

class RaizCuadrada
{
    static void Main()
    {
        // Calcular raíz cuadrada
        double numero = 16;
        double raiz = Math.Sqrt(numero);
        
        Console.WriteLine($"La raíz cuadrada de {numero} es: {raiz}");

        // Probar con más números
        Console.WriteLine("\n=== Raíces cuadradas de varios números ===");
        double[] numeros = { 4, 9, 25, 36, 100, 2 };

        foreach (double num in numeros)
        {
            double raizNum = Math.Sqrt(num);
            Console.WriteLine($"√{num} = {raizNum:F2}");
        }

        // Validación: verificar si es un cuadrado perfecto
        Console.WriteLine("\n=== Cuadrados perfectos ===");
        for (int i = 1; i <= 100; i++)
        {
            double raizI = Math.Sqrt(i);
            if (raizI == Math.Floor(raizI))
            {
                Console.WriteLine($"{i} es un cuadrado perfecto (√{i} = {(int)raizI})");
            }
        }
    }
}
