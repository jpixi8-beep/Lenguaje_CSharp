/*
 * EJERCICIO: Concatenar Nombre y Apellido
 * DESCRIPCIÓN: Combinar dos strings para crear un nombre completo
 * CONCEPTOS: String concatenation, String interpolation
 */

using System;

class ConcatenarNombres
{
    static void Main()
    {
        string nombre = "Carlos";
        string apellido = "Pérez";

        // Forma 1: Usar el operador +
        string nombreCompleto1 = nombre + " " + apellido;
        Console.WriteLine("Forma 1: " + nombreCompleto1);

        // Forma 2: Usar interpolación de strings
        string nombreCompleto2 = $"{nombre} {apellido}";
        Console.WriteLine("Forma 2: " + nombreCompleto2);
    }
}
