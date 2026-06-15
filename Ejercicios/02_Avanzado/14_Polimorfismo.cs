/*
 * EJERCICIO: Polimorfismo
 * DESCRIPCIÓN: Implementar polimorfismo con métodos virtual
 * CONCEPTOS: Polimorfismo, virtual, override
 */

using System;
using System.Collections.Generic;

class Polimorfismo
{
    static void Main()
    {
        Console.WriteLine("=== POLIMORFISMO ===\n");

        List<Forma> formas = new List<Forma>
        {
            new Circulo(5),
            new Rectangulo(4, 6),
            new Triangulo(3, 4)
        };

        Console.WriteLine("--- Cálculo de áreas ---\n");
        double areaTotal = 0;

        foreach (Forma forma in formas)
        {
            double area = forma.CalcularArea();
            areaTotal += area;
            forma.Mostrar();
            Console.WriteLine($"Área: {area:F2}\n");
        }

        Console.WriteLine($"Área total: {areaTotal:F2}");
    }
}

abstract class Forma
{
    public abstract double CalcularArea();
    
    public virtual void Mostrar()
    {
        Console.WriteLine($"Forma: {this.GetType().Name}");
    }
}

class Circulo : Forma
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Radio: {radio}");
    }
}

class Rectangulo : Forma
{
    private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public override double CalcularArea()
    {
        return ancho * alto;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Ancho: {ancho}, Alto: {alto}");
    }
}

class Triangulo : Forma
{
    private double baseRect;
    private double altura;

    public Triangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return (baseRect * altura) / 2;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine($"Base: {baseRect}, Altura: {altura}");
    }
}
