/*
 * EJERCICIO: Expresiones Lambda
 * DESCRIPCIÓN: Usar funciones lambda para código más conciso
 * CONCEPTOS: Lambda expressions, Func, Action
 */

using System;
using System.Collections.Generic;

class ExpresionesLambda
{
    static void Main()
    {
        Console.WriteLine("=== EXPRESIONES LAMBDA ===\n");

        // Lambda simple para sumar
        Func<int, int, int> sumar = (a, b) => a + b;
        Console.WriteLine($"Suma: 5 + 3 = {sumar(5, 3)}");

        // Lambda para verificar si es par
        Func<int, bool> esPar = n => n % 2 == 0;
        Console.WriteLine($"¿5 es par?: {esPar(5)}");
        Console.WriteLine($"¿4 es par?: {esPar(4)}");

        // Lambda con Action (sin retorno)
        Action<string> saludar = nombre => Console.WriteLine($"¡Hola, {nombre}!");
        saludar("Juan");
        saludar("María");

        // Lambda con lista
        Console.WriteLine("\n--- Procesando lista con lambda ---");
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        
        numeros.ForEach(n => Console.Write($"{n * 2} "));
        Console.WriteLine();

        // Lambda compleja
        Func<int, string> clasificar = num =>
        {
            if (num < 0) return "Negativo";
            if (num == 0) return "Cero";
            return "Positivo";
        };

        Console.WriteLine($"\n-5 es: {clasificar(-5)}");
        Console.WriteLine($"0 es: {clasificar(0)}");
        Console.WriteLine($"10 es: {clasificar(10)}");
    }
}
