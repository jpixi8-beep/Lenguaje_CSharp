/*
 * EJERCICIO: Números Aleatorios
 * DESCRIPCIÓN: Generar números aleatorios usando Random
 * CONCEPTOS: Random, Random.Next()
 */

using System;

class NumerosAleatorios
{
    static void Main()
    {
        Random random = new Random();

        // Generar números aleatorios entre 1 y 10
        Console.WriteLine("=== Números aleatorios entre 1 y 10 ===");
        for (int i = 0; i < 5; i++)
        {
            int numeroAleatorio = random.Next(1, 11); // 1 a 10
            Console.WriteLine($"Número {i + 1}: {numeroAleatorio}");
        }

        // Generar números aleatorios entre 1 y 100
        Console.WriteLine("\n=== Números aleatorios entre 1 y 100 ===");
        for (int i = 0; i < 5; i++)
        {
            int numeroAleatorio = random.Next(1, 101);
            Console.WriteLine($"Número {i + 1}: {numeroAleatorio}");
        }

        // Simular lanzamiento de dados
        Console.WriteLine("\n=== Simulación de dados ===");
        for (int i = 0; i < 5; i++)
        {
            int dado = random.Next(1, 7);
            Console.WriteLine($"Lanzamiento {i + 1}: {dado}");
        }
    }
}
