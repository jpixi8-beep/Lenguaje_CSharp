/*
 * EJERCICIO: Clase Persona
 * DESCRIPCIÓN: Crear una clase Persona con propiedades y métodos
 * CONCEPTOS: Clases, propiedades, métodos, encapsulamiento
 */

using System;

class ClasePersona
{
    static void Main()
    {
        Console.WriteLine("=== CLASE PERSONA ===\n");

        // Crear instancias
        Persona persona1 = new Persona("Juan", "García", 25);
        Persona persona2 = new Persona("María", "López", 30);

        // Mostrar información
        persona1.MostrarInfo();
        persona2.MostrarInfo();

        // Usar métodos
        Console.WriteLine($"\n{persona1.nombre} tiene {persona1.CalcularEdadAlCuadrado()} años cuadrados");
        Console.WriteLine($"{persona2.nombre} en 5 años tendrá {persona2.EdadEnAños(5)} años");

        // Modificar propiedades
        persona1.edad = 26;
        Console.WriteLine($"\n{persona1.nombre} ahora tiene {persona1.edad} años");
    }
}

class Persona
{
    public string nombre;
    public string apellido;
    public int edad;

    public Persona(string nombre, string apellido, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre} {apellido}");
        Console.WriteLine($"Edad: {edad} años\n");
    }

    public string NombreCompleto()
    {
        return $"{nombre} {apellido}";
    }

    public int CalcularEdadAlCuadrado()
    {
        return edad * edad;
    }

    public int EdadEnAños(int años)
    {
        return edad + años;
    }

    public bool EsMayorDeEdad()
    {
        return edad >= 18;
    }
}
