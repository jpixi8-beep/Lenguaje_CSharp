/*
 * EJERCICIO: Herencia Básica
 * DESCRIPCIÓN: Crear una jerarquía de clases con herencia
 * CONCEPTOS: Herencia, base, override
 */

using System;

class HerenciaBasica
{
    static void Main()
    {
        Console.WriteLine("=== HERENCIA BÁSICA ===\n");

        Perro perro = new Perro("Rex", "Pastor Alemán");
        Gato gato = new Gato("Whiskers", "Persa");

        Console.WriteLine("--- Perro ---");
        perro.Presentarse();
        perro.Hacer();

        Console.WriteLine("\n--- Gato ---");
        gato.Presentarse();
        gato.Hacer();
    }
}

class Animal
{
    public string nombre;
    public string raza;

    public Animal(string nombre, string raza)
    {
        this.nombre = nombre;
        this.raza = raza;
    }

    public virtual void Presentarse()
    {
        Console.WriteLine($"Soy {nombre}, una {raza}");
    }

    public virtual void Hacer()
    {
        Console.WriteLine("Estoy haciendo algo");
    }
}

class Perro : Animal
{
    public Perro(string nombre, string raza) : base(nombre, raza)
    {
    }

    public override void Hacer()
    {
        Console.WriteLine($"{nombre} está ladrando: ¡GUAU GUAU!");
    }

    public void Traer(string objeto)
    {
        Console.WriteLine($"{nombre} está trayendo {objeto}");
    }
}

class Gato : Animal
{
    public Gato(string nombre, string raza) : base(nombre, raza)
    {
    }

    public override void Hacer()
    {
        Console.WriteLine($"{nombre} está maullando: ¡MIAU MIAU!");
    }

    public void Rasguñar(string objeto)
    {
        Console.WriteLine($"{nombre} está rasguñando {objeto}");
    }
}
