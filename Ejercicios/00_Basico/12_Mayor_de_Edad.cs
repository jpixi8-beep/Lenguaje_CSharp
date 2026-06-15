/*
 * EJERCICIO: Mayor de Edad
 * DESCRIPCIÓN: Verificar si una persona es mayor o menor de edad
 * CONCEPTOS: if-else, operadores de comparación
 */

using System;

class MayordeEdad
{
    static void Main()
    {
        int edad = 20;

        if (edad >= 18)
        {
            Console.WriteLine($"Con {edad} años, eres mayor de edad.");
        }
        else
        {
            int añosFaltan = 18 - edad;
            Console.WriteLine($"Con {edad} años, eres menor de edad. Faltan {añosFaltan} años.");
        }

        // Probar con otra edad
        edad = 15;
        string estado = edad >= 18 ? "Mayor de edad" : "Menor de edad";
        Console.WriteLine($"Con {edad} años: {estado}");
    }
}
