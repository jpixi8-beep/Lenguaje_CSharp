/*
 * EJERCICIO: Calculadora Simple
 * DESCRIPCIÓN: Realizar operaciones básicas (+, -, *, /)
 * CONCEPTOS: Operadores aritméticos
 */

using System;

class CalculadoraSimple
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 5;

        // Suma
        int suma = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {suma}");

        // Resta
        int resta = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {resta}");

        // Multiplicación
        int multiplicacion = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {multiplicacion}");

        // División
        int division = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {division}");

        // Módulo (residuo)
        int modulo = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {modulo}");
    }
}
