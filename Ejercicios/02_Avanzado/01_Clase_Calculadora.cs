/*
 * EJERCICIO: Clase Calculadora
 * DESCRIPCIÓN: Crear una clase Calculadora básica con métodos
 * CONCEPTOS: Clases, métodos, POO
 */

using System;

class ClaseCalculadora
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("=== CALCULADORA CON CLASE ===\n");

        // Realizar operaciones
        int resultado1 = calc.Sumar(10, 5);
        Console.WriteLine($"10 + 5 = {resultado1}");

        int resultado2 = calc.Restar(10, 5);
        Console.WriteLine($"10 - 5 = {resultado2}");

        int resultado3 = calc.Multiplicar(10, 5);
        Console.WriteLine($"10 * 5 = {resultado3}");

        double resultado4 = calc.Dividir(10, 5);
        Console.WriteLine($"10 / 5 = {resultado4}");

        int resultado5 = calc.Modulo(10, 3);
        Console.WriteLine($"10 % 3 = {resultado5}");
    }
}

class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public double Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero");
            return 0;
        }
        return (double)a / b;
    }

    public int Modulo(int a, int b)
    {
        return a % b;
    }
}
