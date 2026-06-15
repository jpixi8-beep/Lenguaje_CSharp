/*
 * EJERCICIO: Sistema Bancario Simple
 * DESCRIPCIÓN: Crear una clase Cuenta bancaria con operaciones
 * CONCEPTOS: Clases, encapsulamiento, validaciones
 */

using System;

class SistemaBancario
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA BANCARIO ===\n");

        // Crear una cuenta
        CuentaBancaria cuenta = new CuentaBancaria("Juan García", 1000.00);

        Console.WriteLine($"Titular: {cuenta.Titular}");
        Console.WriteLine($"Saldo inicial: ${cuenta.ObtenerSaldo():F2}\n");

        // Realizar operaciones
        cuenta.Depositar(500);
        Console.WriteLine($"Después de depositar $500: ${cuenta.ObtenerSaldo():F2}");

        cuenta.Retirar(200);
        Console.WriteLine($"Después de retirar $200: ${cuenta.ObtenerSaldo():F2}");

        cuenta.Retirar(2000); // Intento de retiro mayor al saldo
        
        // Información completa
        Console.WriteLine($"\n--- Resumen de Cuenta ---");
        cuenta.MostrarResumen();
    }
}

class CuentaBancaria
{
    private string titular;
    private double saldo;
    private int movimientos = 0;

    public string Titular 
    { 
        get { return titular; } 
    }

    public CuentaBancaria(string titular, double saldoInicial)
    {
        this.titular = titular;
        this.saldo = saldoInicial;
    }

    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            movimientos++;
            Console.WriteLine($"✓ Depósito de ${cantidad:F2} realizado");
        }
        else
        {
            Console.WriteLine("❌ La cantidad debe ser positiva");
        }
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                movimientos++;
                Console.WriteLine($"✓ Retiro de ${cantidad:F2} realizado");
            }
            else
            {
                Console.WriteLine($"❌ Saldo insuficiente. Disponible: ${saldo:F2}");
            }
        }
        else
        {
            Console.WriteLine("❌ La cantidad debe ser positiva");
        }
    }

    public double ObtenerSaldo()
    {
        return saldo;
    }

    public void MostrarResumen()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: ${saldo:F2}");
        Console.WriteLine($"Movimientos: {movimientos}");
    }
}
