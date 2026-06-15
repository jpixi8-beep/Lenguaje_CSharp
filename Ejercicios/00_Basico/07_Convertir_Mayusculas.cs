/*
 * EJERCICIO: Convertir Texto a Mayúsculas y Minúsculas
 * DESCRIPCIÓN: Cambiar el case de los caracteres de un string
 * CONCEPTOS: String.ToUpper(), String.ToLower()
 */

using System;

class ConvertirMayusculas
{
    static void Main()
    {
        string texto = "Hola C# World";

        // Convertir a mayúsculas
        string mayusculas = texto.ToUpper();
        Console.WriteLine($"Original: {texto}");
        Console.WriteLine($"Mayúsculas: {mayusculas}");

        // Convertir a minúsculas
        string minusculas = texto.ToLower();
        Console.WriteLine($"Minúsculas: {minusculas}");

        // Primera letra mayúscula
        string nombre = "juan";
        string nombreCapitalizado = nombre[0].ToString().ToUpper() + nombre.Substring(1);
        Console.WriteLine($"Capitalizado: {nombreCapitalizado}");
    }
}
