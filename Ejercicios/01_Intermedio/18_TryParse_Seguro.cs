/*
 * EJERCICIO: TryParse Seguro
 * DESCRIPCIÓN: Conversión segura de string a números
 * CONCEPTOS: int.TryParse(), double.TryParse(), manejo de errores
 */

using System;

class TryParseSseguro
{
    static void Main()
    {
        Console.WriteLine("=== Conversión Segura con TryParse ===\n");

        // Ejemplo 1: String válido
        Console.WriteLine("=== Ejemplo 1: Número válido ===");
        string entrada1 = "123";
        if (int.TryParse(entrada1, out int resultado1))
        {
            Console.WriteLine($"✓ Conversión exitosa: \"{entrada1}\" → {resultado1}");
        }
        else
        {
            Console.WriteLine($"❌ No se pudo convertir: \"{entrada1}\"");
        }

        // Ejemplo 2: String inválido
        Console.WriteLine("\n=== Ejemplo 2: Número inválido ===");
        string entrada2 = "abc";
        if (int.TryParse(entrada2, out int resultado2))
        {
            Console.WriteLine($"✓ Conversión exitosa: \"{entrada2}\" → {resultado2}");
        }
        else
        {
            Console.WriteLine($"❌ No se pudo convertir: \"{entrada2}\" (no es un número)");
        }

        // Ejemplo 3: Double
        Console.WriteLine("\n=== Ejemplo 3: Double válido ===");
        string entrada3 = "3.14";
        if (double.TryParse(entrada3, out double resultado3))
        {
            Console.WriteLine($"✓ Conversión exitosa: \"{entrada3}\" → {resultado3}");
        }

        // Ejemplo 4: Entrada del usuario
        Console.WriteLine("\n=== Ejemplo 4: Entrada del usuario ===");
        Console.Write("Ingresa un número: ");
        string entrada4 = Console.ReadLine();
        
        if (int.TryParse(entrada4, out int resultado4))
        {
            Console.WriteLine($"✓ Has ingresado el número: {resultado4}");
            Console.WriteLine($"  El doble es: {resultado4 * 2}");
        }
        else
        {
            Console.WriteLine($"❌ '{entrada4}' no es un número válido");
        }
    }
}
