/*
 * EJERCICIO: Extraer las primeras letras de un string
 * DESCRIPCIÓN: Obtener una porción de un string usando Substring()
 * CONCEPTOS: String.Substring()
 */

using System;

class ExtraerLetras
{
    static void Main()
    {
        string palabra = "Programación";

        // Extraer los primeros 3 caracteres
        string primerasTres = palabra.Substring(0, 3);
        Console.WriteLine($"Palabra original: {palabra}");
        Console.WriteLine($"Primeras 3 letras: {primerasTres}");

        // Extraer otros substrings
        string desde5 = palabra.Substring(5, 4); // "amac"
        Console.WriteLine($"Desde posición 5, 4 caracteres: {desde5}");

        // Extraer desde una posición hasta el final
        string desde7 = palabra.Substring(7);
        Console.WriteLine($"Desde posición 7 hasta el final: {desde7}");
    }
}
