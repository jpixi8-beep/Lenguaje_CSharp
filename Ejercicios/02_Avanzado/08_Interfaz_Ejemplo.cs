/*
 * EJERCICIO: Interfaz Ejemplo
 * DESCRIPCIÓN: Crear interfaces para definir contratos
 * CONCEPTOS: Interfaces, implementación, abstracción
 */

using System;

class InterfazEjemplo
{
    static void Main()
    {
        Console.WriteLine("=== INTERFACES EJEMPLO ===\n");

        Coche coche = new Coche("Toyota", "Corolla", 2020);
        Moto moto = new Moto("Yamaha", "YZF-R3", 2021);

        Console.WriteLine("--- Coche ---");
        coche.Encender();
        coche.Acelerar();
        coche.MostrarInfo();

        Console.WriteLine("\n--- Moto ---");
        moto.Encender();
        moto.Acelerar();
        moto.MostrarInfo();
    }
}

interface IVehiculo
{
    void Encender();
    void Apagar();
    void Acelerar();
    void Frenar();
    void MostrarInfo();
}

class Coche : IVehiculo
{
    private string marca;
    private string modelo;
    private int año;
    private bool encendido = false;

    public Coche(string marca, string modelo, int año)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
    }

    public void Encender()
    {
        encendido = true;
        Console.WriteLine("🚗 El coche está encendido");
    }

    public void Apagar()
    {
        encendido = false;
        Console.WriteLine("🚗 El coche está apagado");
    }

    public void Acelerar()
    {
        if (encendido)
            Console.WriteLine("🚗 ¡VROOM VROOM! El coche está acelerando");
    }

    public void Frenar()
    {
        Console.WriteLine("🚗 ¡SHHH! El coche está frenando");
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Año: {año}");
    }
}

class Moto : IVehiculo
{
    private string marca;
    private string modelo;
    private int año;
    private bool encendida = false;

    public Moto(string marca, string modelo, int año)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
    }

    public void Encender()
    {
        encendida = true;
        Console.WriteLine("🏍️ La moto está encendida");
    }

    public void Apagar()
    {
        encendida = false;
        Console.WriteLine("🏍️ La moto está apagada");
    }

    public void Acelerar()
    {
        if (encendida)
            Console.WriteLine("🏍️ ¡BRRRRR! La moto está acelerando");
    }

    public void Frenar()
    {
        Console.WriteLine("🏍️ ¡SCREECH! La moto está frenando");
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Año: {año}");
    }
}
