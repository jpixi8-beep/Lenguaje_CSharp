/*
 * EJERCICIO: Validar Entrada del Usuario
 * DESCRIPCIÓN: Validar que el usuario ingrese un número válido
 * CONCEPTOS: do-while loop, int.TryParse()
 */

using System;

class ValidarEntrada
{
    static void Main()
    {
        // Solicitar un número válido
        Console.WriteLine("=== Validación de entrada ===");
        int numero = ObtenerNumero("Ingresa un número entre 1 y 100: ");
        
        if (numero >= 1 && numero <= 100)
        {
            Console.WriteLine($"✓ {numero} es un número válido");
        }
        else
        {
            Console.WriteLine($"✗ {numero} está fuera del rango");
        }

        // Validar múltiples entradas
        Console.WriteLine("\n=== Validar múltiples números ===");
        for (int i = 0; i < 3; i++)
        {
            int num = ObtenerNumero($"Número {i + 1}: ");
            Console.WriteLine($"Has ingresado: {num}\n");
        }
    }

    static int ObtenerNumero(string mensaje)
    {
        int numero = 0;
        bool valido = false;

        do
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("❌ Error: Debes ingresar un número entero válido");
            }
        } while (!valido);

        return numero;
    }
}
