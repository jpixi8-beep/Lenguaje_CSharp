/*
 * EJERCICIO: Buscar si una Palabra contiene texto
 * DESCRIPCIÓN: Verificar si un string contiene una palabra clave
 * CONCEPTOS: String.Contains()
 */

using System;

class BuscarPalabra
{
    static void Main()
    {
        string texto = "Aprendiendo C# es divertido";

        // Buscar si contiene "C#"
        bool contieneCSharp = texto.Contains("C#");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"¿Contiene 'C#'?: {contieneCSharp}");

        // Buscar otras palabras
        bool contieneAprender = texto.Contains("Aprendiendo");
        Console.WriteLine($"¿Contiene 'Aprendiendo'?: {contieneAprender}");

        bool contienePython = texto.Contains("Python");
        Console.WriteLine($"¿Contiene 'Python'?: {contienePython}");
    }
}
