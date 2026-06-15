/*
 * EJERCICIO: Reemplazar Espacios por Guiones
 * DESCRIPCIÓN: Cambiar todos los espacios de un texto por otro carácter
 * CONCEPTOS: String.Replace()
 */

using System;

class ReemplazarEspacios
{
    static void Main()
    {
        string frase = "Hola mundo desde C#";

        // Reemplazar espacios por guiones
        string fraseConGuiones = frase.Replace(" ", "-");
        Console.WriteLine($"Original: {frase}");
        Console.WriteLine($"Con guiones: {fraseConGuiones}");

        // Otros reemplazos
        string fraseConSubrayas = frase.Replace(" ", "_");
        Console.WriteLine($"Con subrayas: {fraseConSubrayas}");

        string fraseSinEspacios = frase.Replace(" ", "");
        Console.WriteLine($"Sin espacios: {fraseSinEspacios}");
    }
}
