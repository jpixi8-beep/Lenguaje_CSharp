/*
 * EJERCICIO: Determinación de Mes
 * DESCRIPCIÓN: Mostrar el nombre del mes según su número
 * CONCEPTOS: switch-case
 */

using System;

class DeterminacionMes
{
    static void Main()
    {
        // Ejemplo individual
        int numeroMes = 5;
        MostrarMes(numeroMes);

        // Tabla de todos los meses
        Console.WriteLine("\n=== Todos los meses ===");
        for (int i = 1; i <= 12; i++)
        {
            MostrarMes(i);
        }
    }

    static void MostrarMes(int numero)
    {
        string nombreMes = "";

        switch (numero)
        {
            case 1:
                nombreMes = "Enero";
                break;
            case 2:
                nombreMes = "Febrero";
                break;
            case 3:
                nombreMes = "Marzo";
                break;
            case 4:
                nombreMes = "Abril";
                break;
            case 5:
                nombreMes = "Mayo";
                break;
            case 6:
                nombreMes = "Junio";
                break;
            case 7:
                nombreMes = "Julio";
                break;
            case 8:
                nombreMes = "Agosto";
                break;
            case 9:
                nombreMes = "Septiembre";
                break;
            case 10:
                nombreMes = "Octubre";
                break;
            case 11:
                nombreMes = "Noviembre";
                break;
            case 12:
                nombreMes = "Diciembre";
                break;
            default:
                nombreMes = "Mes inválido";
                break;
        }

        Console.WriteLine($"Mes {numero:D2} = {nombreMes}");
    }
}
