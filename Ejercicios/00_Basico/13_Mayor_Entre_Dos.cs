/*
 * EJERCICIO: Mayor Entre Dos Números
 * DESCRIPCIÓN: Comparar dos números y mostrar cuál es mayor
 * CONCEPTOS: if-else, Math.Max()
 */

using System;

class MayorEntreDos
{
    static void Main()
    {
        int numero1 = 15;
        int numero2 = 23;

        // Forma 1: Usando if-else
        Console.WriteLine("=== Forma 1: if-else ===");
        if (numero1 > numero2)
        {
            Console.WriteLine($"El mayor es: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"El mayor es: {numero2}");
        }
        else
        {
            Console.WriteLine("Ambos números son iguales");
        }

        // Forma 2: Usando Math.Max()
        Console.WriteLine("\n=== Forma 2: Math.Max() ===");
        int mayor = Math.Max(numero1, numero2);
        Console.WriteLine($"El mayor es: {mayor}");

        // Forma 3: Usando operador ternario
        Console.WriteLine("\n=== Forma 3: Operador Ternario ===");
        string resultado = numero1 > numero2 ? 
            $"{numero1} es mayor" : 
            numero2 > numero1 ? 
            $"{numero2} es mayor" : 
            "Son iguales";
        Console.WriteLine(resultado);
    }
}
