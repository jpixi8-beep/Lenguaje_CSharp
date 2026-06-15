/*
 * EJERCICIO: Propiedades con Get y Set
 * DESCRIPCIÓN: Usar propiedades para acceso controlado a datos
 * CONCEPTOS: Propiedades, getters, setters, validación
 */

using System;

class PropiedadesGetSet
{
    static void Main()
    {
        Console.WriteLine("=== PROPIEDADES CON GET Y SET ===\n");

        Estudiante est = new Estudiante();

        // Usar propiedades con set
        est.Nombre = "Carlos";
        est.Edad = 20;
        est.Calificacion = 85;

        // Usar propiedades con get
        Console.WriteLine($"Nombre: {est.Nombre}");
        Console.WriteLine($"Edad: {est.Edad}");
        Console.WriteLine($"Calificación: {est.Calificacion}");
        Console.WriteLine($"Estado: {est.Estado}");

        // Intentar valores inválidos
        Console.WriteLine("\n=== Intentos de asignar valores inválidos ===");
        est.Edad = -5; // No se asignará
        est.Calificacion = 150; // No se asignará

        Console.WriteLine($"Edad después del intento: {est.Edad}");
        Console.WriteLine($"Calificación después del intento: {est.Calificacion}");
    }
}

class Estudiante
{
    private string nombre;
    private int edad;
    private int calificacion;

    // Propiedad para nombre
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad para edad con validación
    public int Edad
    {
        get { return edad; }
        set 
        { 
            if (value > 0 && value < 120)
                edad = value;
            else
                Console.WriteLine("❌ La edad debe estar entre 1 y 120");
        }
    }

    // Propiedad para calificación con validación
    public int Calificacion
    {
        get { return calificacion; }
        set 
        { 
            if (value >= 0 && value <= 100)
                calificacion = value;
            else
                Console.WriteLine("❌ La calificación debe estar entre 0 y 100");
        }
    }

    // Propiedad de solo lectura (sin setter)
    public string Estado
    {
        get 
        { 
            if (calificacion >= 90) return "Excelente";
            if (calificacion >= 80) return "Muy Bien";
            if (calificacion >= 70) return "Bien";
            if (calificacion >= 60) return "Regular";
            return "Insuficiente";
        }
    }
}
