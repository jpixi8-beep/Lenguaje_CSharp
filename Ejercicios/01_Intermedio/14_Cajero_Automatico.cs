/*
 * EJERCICIO: Menú de Cajero Automático
 * DESCRIPCIÓN: Simular un cajero automático con menú switch
 * CONCEPTOS: switch-case, do-while, operaciones bancarias
 */

using System;

class CajeroAutomatico
{
    static void Main()
    {
        double saldo = 1000.00;
        bool salir = false;

        do
        {
            MostrarMenu();
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ConsultarSaldo(saldo);
                    break;
                case "2":
                    saldo = Depositar(saldo);
                    break;
                case "3":
                    saldo = Retirar(saldo);
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("Gracias por usar el cajero. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("❌ Opción inválida. Intenta de nuevo.\n");
                    break;
            }
        } while (!salir);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n=== CAJERO AUTOMÁTICO ===");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero");
        Console.WriteLine("4. Salir");
    }

    static void ConsultarSaldo(double saldo)
    {
        Console.WriteLine($"\n✓ Tu saldo actual es: ${saldo:F2}\n");
    }

    static double Depositar(double saldo)
    {
        Console.Write("\nIngresa la cantidad a depositar: $");
        if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"✓ Depósito exitoso. Nuevo saldo: ${saldo:F2}\n");
        }
        else
        {
            Console.WriteLine("❌ Cantidad inválida\n");
        }
        return saldo;
    }

    static double Retirar(double saldo)
    {
        Console.Write("\nIngresa la cantidad a retirar: $");
        if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"✓ Retiro exitoso. Nuevo saldo: ${saldo:F2}\n");
            }
            else
            {
                Console.WriteLine("❌ Saldo insuficiente\n");
            }
        }
        else
        {
            Console.WriteLine("❌ Cantidad inválida\n");
        }
        return saldo;
    }
}
