/*
 * EJERCICIO: Genéricos Básicos
 * DESCRIPCIÓN: Crear clases genéricas que funcionan con múltiples tipos
 * CONCEPTOS: Genéricos, <T>, constraints
 */

using System;

class GenericosBasicos
{
    static void Main()
    {
        Console.WriteLine("=== GENÉRICOS BÁSICOS ===\n");

        // Genérico con int
        Contenedor<int> intBox = new Contenedor<int>(42);
        Console.WriteLine($"Contenedor<int>: {intBox.Obtener()}");

        // Genérico con string
        Contenedor<string> stringBox = new Contenedor<string>("Hola");
        Console.WriteLine($"Contenedor<string>: {stringBox.Obtener()}");

        // Genérico con doble
        Contenedor<double> doubleBox = new Contenedor<double>(3.14);
        Console.WriteLine($"Contenedor<double>: {doubleBox.Obtener()}");

        // Método genérico
        Console.WriteLine("\n--- Método Genérico ---");
        int[] numeros = { 1, 2, 3, 4, 5 };
        MostrarArray(numeros);

        string[] palabras = { "Hola", "Mundo", "C#" };
        MostrarArray(palabras);
    }

    static void MostrarArray<T>(T[] items)
    {
        foreach (T item in items)
            Console.Write($"{item} ");
        Console.WriteLine();
    }
}

class Contenedor<T>
{
    private T contenido;

    public Contenedor(T contenido)
    {
        this.contenido = contenido;
    }

    public T Obtener()
    {
        return contenido;
    }

    public void Establecer(T nuevoContenido)
    {
        contenido = nuevoContenido;
    }
}
