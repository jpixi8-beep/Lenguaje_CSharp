/*
 * EJERCICIO: Convertir String a Int
 * DESCRIPCIÓN: Convertir texto a números enteros
 * CONCEPTOS: Convert.ToInt32(), int.Parse()
 */

using System;

class ConvertirStringAInt
{
    static void Main()
    {
        Console.WriteLine("=== Conversión de String a Int ===\n");

        // Forma 1: Usando Convert.ToInt32()
        Console.WriteLine("=== Forma 1: Convert.ToInt32() ===");
        string texto1 = "123";
        int numero1 = Convert.ToInt32(texto1);
        Console.WriteLine($"Texto: \"{texto1}\" → Número: {numero1}");

        // Forma 2: Usando int.Parse()
        Console.WriteLine("\n=== Forma 2: int.Parse() ===");
        string texto2 = "456";
        int numero2 = int.Parse(texto2);
        Console.WriteLine($"Texto: \"{texto2}\" → Número: {numero2}");

        // Conversión con números negativos
        Console.WriteLine("\n=== Con números negativos ===");
        string texto3 = "-789";
        int numero3 = int.Parse(texto3);
        Console.WriteLine($"Texto: \"{texto3}\" → Número: {numero3}");

        // Operaciones con números convertidos
        Console.WriteLine("\n=== Operaciones con números convertidos ===");
        string a = "10";
        string b = "20";
        int numA = int.Parse(a);
        int numB = int.Parse(b);
        Console.WriteLine($"Suma: {numA} + {numB} = {numA + numB}");
        Console.WriteLine($"Resta: {numA} - {numB} = {numA - numB}");
        Console.WriteLine($"Multiplicación: {numA} * {numB} = {numA * numB}");
    }
}
