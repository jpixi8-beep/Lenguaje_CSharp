/*
 * EJERCICIO: LINQ Básico
 * DESCRIPCIÓN: Usar LINQ para consultas sobre colecciones
 * CONCEPTOS: LINQ, Where, Select, OrderBy
 */

using System;
using System.Linq;
using System.Collections.Generic;

class LinqBasico
{
    static void Main()
    {
        Console.WriteLine("=== LINQ BÁSICO ===\n");

        // Lista de números
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtrar números pares
        Console.WriteLine("--- Números pares ---");
        var pares = numeros.Where(n => n % 2 == 0);
        foreach (int num in pares)
            Console.Write($"{num} ");
        Console.WriteLine();

        // Doblar números
        Console.WriteLine("\n--- Números doblados ---");
        var doblados = numeros.Select(n => n * 2);
        foreach (int num in doblados)
            Console.Write($"{num} ");
        Console.WriteLine();

        // Filtrar y doblar
        Console.WriteLine("\n--- Números pares doblados ---");
        var paresDoblados = numeros.Where(n => n % 2 == 0).Select(n => n * 2);
        foreach (int num in paresDoblados)
            Console.Write($"{num} ");
        Console.WriteLine();

        // Ordenar descendente
        Console.WriteLine("\n--- Números descendentes ---");
        var descendentes = numeros.OrderByDescending(n => n);
        foreach (int num in descendentes)
            Console.Write($"{num} ");
        Console.WriteLine();

        // Con objetos
        Console.WriteLine("\n--- Estudiantes con calificación > 80 ---");
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Juan", 85),
            new Estudiante("María", 92),
            new Estudiante("Carlos", 78),
            new Estudiante("Ana", 88)
        };

        var aprobados = estudiantes.Where(e => e.calificacion > 80).OrderByDescending(e => e.calificacion);
        foreach (var est in aprobados)
            Console.WriteLine($"{est.nombre}: {est.calificacion}");
    }
}

class Estudiante
{
    public string nombre;
    public int calificacion;

    public Estudiante(string nombre, int calificacion)
    {
        this.nombre = nombre;
        this.calificacion = calificacion;
    }
}
