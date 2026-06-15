/*
 * EJERCICIO: Convertir String a Double
 * DESCRIPCIÓN: Convertir texto a números decimales
 * CONCEPTOS: Convert.ToDouble(), double.Parse()
 */

using System;

class ConvertirStringADouble
{
    static void Main()
    {
        Console.WriteLine("=== Conversión de String a Double ===\n");

        // Forma 1: Usando Convert.ToDouble()
        Console.WriteLine("=== Forma 1: Convert.ToDouble() ===");
        string texto1 = "3.14";
        double numero1 = Convert.ToDouble(texto1);
        Console.WriteLine($"Texto: \"{texto1}\" → Número: {numero1}");

        // Forma 2: Usando double.Parse()
        Console.WriteLine("\n=== Forma 2: double.Parse() ===");
        string texto2 = "2.5";
        double numero2 = double.Parse(texto2);
        Console.WriteLine($"Texto: \"{texto2}\" → Número: {numero2}");

        // Conversión con números negativos
        Console.WriteLine("\n=== Con números negativos ===");
        string texto3 = "-99.99";
        double numero3 = double.Parse(texto3);
        Console.WriteLine($"Texto: \"{texto3}\" → Número: {numero3}");

        // Operaciones con números convertidos
        Console.WriteLine("\n=== Operaciones con números convertidos ===");
        string base1 = "10.5";
        string base2 = "3.2";
        double numBase1 = double.Parse(base1);
        double numBase2 = double.Parse(base2);
        Console.WriteLine($"Suma: {numBase1} + {numBase2} = {numBase1 + numBase2:F2}");
        Console.WriteLine($"Resta: {numBase1} - {numBase2} = {numBase1 - numBase2:F2}");
        Console.WriteLine($"Multiplicación: {numBase1} * {numBase2} = {numBase1 * numBase2:F2}");
        Console.WriteLine($"División: {numBase1} / {numBase2} = {numBase1 / numBase2:F2}");
    }
}
