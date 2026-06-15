/*
 * EJERCICIO: Calculadora Modular
 * DESCRIPCIÓN: Calculadora con métodos estáticos y modularidad
 * CONCEPTOS: Métodos estáticos, modularidad
 */

using System;

class CalculadoraModular
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA MODULAR ===\n");

        double num1 = 15;
        double num2 = 4;

        Console.WriteLine($"Números: {num1} y {num2}\n");

        // Usar métodos estáticos
        Console.WriteLine("=== Operaciones Básicas ===");
        Console.WriteLine($"Suma: {Calculadora.Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {Calculadora.Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {Calculadora.Multiplicar(num1, num2)}");
        Console.WriteLine($"División: {Calculadora.Dividir(num1, num2):F2}");

        Console.WriteLine("\n=== Operaciones Avanzadas ===");
        Console.WriteLine($"Potencia: {Calculadora.Potencia(num1, num2):F2}");
        Console.WriteLine($"Raíz Cuadrada de {num1}: {Calculadora.RaizCuadrada(num1):F2}");
        Console.WriteLine($"Valor Absoluto de {num2}: {Calculadora.ValorAbsoluto(num2):F2}");
    }
}

class Calculadora
{
    public static double Sumar(double a, double b) => a + b;
    public static double Restar(double a, double b) => a - b;
    public static double Multiplicar(double a, double b) => a * b;
    
    public static double Dividir(double a, double b)
    {
        if (b == 0)
            throw new ArgumentException("No se puede dividir entre cero");
        return a / b;
    }

    public static double Potencia(double a, double b) => Math.Pow(a, b);
    public static double RaizCuadrada(double a) => Math.Sqrt(a);
    public static double ValorAbsoluto(double a) => Math.Abs(a);
}
