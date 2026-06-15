/*
 * EJERCICIO: Manejo de Excepciones
 * DESCRIPCIÓN: Usar try-catch para manejar errores
 * CONCEPTOS: try-catch-finally, excepciones, throw
 */

using System;

class ManejoExcepciones
{
    static void Main()
    {
        Console.WriteLine("=== MANEJO DE EXCEPCIONES ===\n");

        // Ejemplo 1: División por cero
        Console.WriteLine("--- Ejemplo 1: División ---");
        try
        {
            int resultado = Dividir(10, 0);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("❌ Error: No se puede dividir entre cero");
        }
        finally
        {
            Console.WriteLine("✓ Operación completada\n");
        }

        // Ejemplo 2: Conversión inválida
        Console.WriteLine("--- Ejemplo 2: Conversión ---");
        try
        {
            string texto = "abc";
            int numero = int.Parse(texto);
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Error: Formato inválido para convertir a número");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error general: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("✓ Conversión intentada\n");
        }

        // Ejemplo 3: Excepción personalizada
        Console.WriteLine("--- Ejemplo 3: Excepción personalizada ---");
        try
        {
            Persona persona = new Persona("Juan", -25);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"❌ {ex.Message}");
        }
    }

    static int Dividir(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("El divisor no puede ser cero");
        return a / b;
    }
}

class Persona
{
    public string nombre;
    public int edad;

    public Persona(string nombre, int edad)
    {
        if (edad < 0)
            throw new ArgumentException("La edad no puede ser negativa");
        
        this.nombre = nombre;
        this.edad = edad;
    }
}
