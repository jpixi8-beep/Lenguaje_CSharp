/*
 * EJERCICIO: Contar Dígitos de un Número
 * DESCRIPCIÓN: Calcular cuántos dígitos tiene un número
 * CONCEPTOS: while loop, división
 */

using System;

class ContarDigitos
{
    static void Main()
    {
        int numero = 12345;

        // Contar dígitos usando while
        int cantidadDigitos = ContarDigitosWhile(numero);
        Console.WriteLine($"El número {numero} tiene {cantidadDigitos} dígitos");

        // Contar dígitos usando string
        int cantidadString = numero.ToString().Length;
        Console.WriteLine($"Verificación con String: {cantidadString} dígitos");

        // Tabla de números y sus dígitos
        Console.WriteLine("\n=== Tabla de números y cantidad de dígitos ===");
        int[] numeros = { 5, 42, 100, 1234, 67890, 999999 };

        foreach (int num in numeros)
        {
            int digitos = ContarDigitosWhile(num);
            Console.WriteLine($"{num:D6} tiene {digitos} dígitos");
        }

        // Número con mayor cantidad de dígitos
        Console.WriteLine("\n=== Encontrar el número con más dígitos ===");
        int[] numeros2 = { 123, 45, 6789, 10, 999999 };
        int maxDigitos = 0;
        int numeroConMasDigitos = 0;

        foreach (int num in numeros2)
        {
            int digitos = ContarDigitosWhile(num);
            if (digitos > maxDigitos)
            {
                maxDigitos = digitos;
                numeroConMasDigitos = num;
            }
        }

        Console.WriteLine($"El número con más dígitos es {numeroConMasDigitos} ({maxDigitos} dígitos)");
    }

    static int ContarDigitosWhile(int numero)
    {
        if (numero == 0)
            return 1;

        numero = Math.Abs(numero);
        int contador = 0;

        while (numero > 0)
        {
            contador++;
            numero /= 10;
        }

        return contador;
    }
}
