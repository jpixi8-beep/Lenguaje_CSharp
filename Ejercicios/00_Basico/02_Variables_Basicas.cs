/*
 * EJERCICIO: Variables Básicas
 * DESCRIPCIÓN: Declarar y usar variables de diferentes tipos
 * CONCEPTOS: int, double, string, bool
 */

using System;

class VariablesBasicas
{
    static void Main()
    {
        // Declarar variables de diferentes tipos
        int edad = 25;
        double altura = 1.75;
        string nombre = "Juan";
        bool esEstudiante = true;

        // Mostrar los valores
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"¿Es estudiante?: {esEstudiante}");
    }
}
