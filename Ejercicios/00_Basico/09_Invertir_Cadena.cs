/*
 * EJERCICIO: Invertir una Cadena
 * DESCRIPCIÓN: Mostrar un string en orden inverso
 * CONCEPTOS: Reverse(), for loop, string concatenation
 */

using System;
using System.Linq;

class InvertirCadena
{
    static void Main()
    {
        string texto = "Hola";

        // Forma 1: Usando LINQ
        string invertido1 = new string(texto.Reverse().ToArray());
        Console.WriteLine($"Original: {texto}");
        Console.WriteLine($"Invertido (LINQ): {invertido1}");

        // Forma 2: Usando un bucle
        string invertido2 = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido2 += texto[i];
        }
        Console.WriteLine($"Invertido (Loop): {invertido2}");

        // Verificar si es palíndromo
        if (texto.ToLower() == invertido1.ToLower())
        {
            Console.WriteLine($"\"{texto}\" es un palíndromo");
        }
        else
        {
            Console.WriteLine($"\"{texto}\" NO es un palíndromo");
        }
    }
}
