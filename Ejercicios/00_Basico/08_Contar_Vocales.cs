/*
 * EJERCICIO: Contar Vocales en una Palabra
 * DESCRIPCIÓN: Recorrer un string y contar cuántas vocales contiene
 * CONCEPTOS: foreach, String.ToLower()
 */

using System;

class ContarVocales
{
    static void Main()
    {
        string palabra = "Programación";
        int conteoVocales = 0;

        // Convertir a minúsculas para la comparación
        string palabraMinuscula = palabra.ToLower();

        // Contar vocales
        foreach (char letra in palabraMinuscula)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                conteoVocales++;
            }
        }

        Console.WriteLine($"Palabra: {palabra}");
        Console.WriteLine($"Total de vocales: {conteoVocales}");
    }
}
