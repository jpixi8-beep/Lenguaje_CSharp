/*
 * EJERCICIO: Invertir un Número
 * DESCRIPCIÓN: Mostrar un número en orden inverso
 * CONCEPTOS: while loop, módulo, división
 */

using System;

class InvertirNumero
{
    static void Main()
    {
        int numero = 12345;

        // Forma 1: Usando while
        Console.WriteLine($"Número original: {numero}");
        int invertido = 0;
        int temp = numero;

        while (temp > 0)
        {
            int digito = temp % 10;
            invertido = invertido * 10 + digito;
            temp /= 10;
        }

        Console.WriteLine($"Número invertido: {invertido}");

        // Verificar si es palíndromo
        if (numero == invertido)
        {
            Console.WriteLine($"{numero} SÍ es un palíndromo");
        }
        else
        {
            Console.WriteLine($"{numero} NO es un palíndromo");
        }

        // Invertir varios números
        Console.WriteLine("\n=== Invertir varios números ===");
        int[] numeros = { 100, 121, 456, 1001, 9876 };

        foreach (int num in numeros)
        {
            int inv = Invertir(num);
            Console.WriteLine($"{num} invertido es {inv}");
        }
    }

    static int Invertir(int numero)
    {
        int invertido = 0;
        while (numero > 0)
        {
            invertido = invertido * 10 + numero % 10;
            numero /= 10;
        }
        return invertido;
    }
}
