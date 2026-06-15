/*
 * EJERCICIO: Convertir a Números Romanos
 * DESCRIPCIÓN: Convertir un número arábigo a número romano
 * CONCEPTOS: switch-case, operadores
 */

using System;

class ConvertirAromanos
{
    static void Main()
    {
        Console.WriteLine("=== Convertidor de números a romanos ===\n");

        int[] numeros = { 1, 4, 9, 10, 27, 49, 58, 99, 100, 444, 999, 1994 };

        foreach (int num in numeros)
        {
            string romano = ConvertirARomano(num);
            Console.WriteLine($"{num:D4} = {romano}");
        }
    }

    static string ConvertirARomano(int numero)
    {
        string romano = "";

        // Símbolos romanos en orden descendente
        int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        for (int i = 0; i < valores.Length; i++)
        {
            while (numero >= valores[i])
            {
                romano += simbolos[i];
                numero -= valores[i];
            }
        }

        return romano;
    }
}
