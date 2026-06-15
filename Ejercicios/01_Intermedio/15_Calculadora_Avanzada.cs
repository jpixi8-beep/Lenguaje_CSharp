/*
 * EJERCICIO: Calculadora Avanzada
 * DESCRIPCIÓN: Calculadora que combina múltiples operadores
 * CONCEPTOS: Operadores aritméticos, operadores compuestos
 */

using System;

class CalculadoraAvanzada
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA AVANZADA ===\n");

        // Números base
        double num1 = 10;
        double num2 = 3;

        // Operaciones básicas
        Console.WriteLine($"Números: {num1} y {num2}");
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División: {num1} / {num2} = {num1 / num2:F2}");
        Console.WriteLine($"Módulo: {num1} % {num2} = {num1 % num2}");

        // Operadores compuestos
        Console.WriteLine("\n=== Operadores Compuestos ===");
        double resultado = 10;
        resultado += 5;
        Console.WriteLine($"10 += 5 → {resultado}");

        resultado -= 3;
        Console.WriteLine($"{resultado - 2} -= 3 → {resultado}");

        resultado *= 2;
        Console.WriteLine($"{resultado / 2} *= 2 → {resultado}");

        resultado /= 4;
        Console.WriteLine($"{resultado * 4} /= 4 → {resultado}");

        // Operadores de incremento y decremento
        Console.WriteLine("\n=== Incremento y Decremento ===");
        int contador = 5;
        Console.WriteLine($"contador = {contador}");
        Console.WriteLine($"++contador = {++contador}");
        Console.WriteLine($"contador++ = {contador++}");
        Console.WriteLine($"--contador = {--contador}");
        Console.WriteLine($"contador-- = {contador--}");

        // Operaciones combinadas
        Console.WriteLine("\n=== Operaciones Combinadas ===");
        double a = 20;
        double b = 5;
        double c = 2;
        double operacion = (a + b) * c - (a / b);
        Console.WriteLine($"({a} + {b}) * {c} - ({a} / {b}) = {operacion}");
    }
}
