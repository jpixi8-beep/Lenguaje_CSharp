/*
 * EJERCICIO: Gestor de Tareas
 * DESCRIPCIÓN: Sistema para gestionar una lista de tareas
 * CONCEPTOS: Arrays, clases, métodos, lógica de negocio
 */

using System;

class GestorTareas
{
    static void Main()
    {
        Console.WriteLine("=== GESTOR DE TAREAS ===\n");

        ListaTareas lista = new ListaTareas();

        // Agregar tareas
        lista.AgregarTarea(new Tarea("Estudiar C#", "Alta"));
        lista.AgregarTarea(new Tarea("Hacer ejercicio", "Media"));
        lista.AgregarTarea(new Tarea("Comprar leche", "Baja"));

        // Mostrar tareas
        Console.WriteLine("--- Tareas pendientes ---");
        lista.MostrarTareas();

        // Completar una tarea
        Console.WriteLine("\nCompletando primera tarea...");
        lista.CompletarTarea(0);

        // Mostrar nuevamente
        Console.WriteLine("\n--- Tareas actualizadas ---");
        lista.MostrarTareas();

        // Estadísticas
        Console.WriteLine("\n--- Estadísticas ---");
        lista.MostrarEstadisticas();
    }
}

class Tarea
{
    public string descripcion;
    public string prioridad;
    public bool completada;

    public Tarea(string descripcion, string prioridad)
    {
        this.descripcion = descripcion;
        this.prioridad = prioridad;
        this.completada = false;
    }

    public void Mostrar(int numero)
    {
        string estado = completada ? "✓ HECHA" : "⏳ PENDIENTE";
        Console.WriteLine($"{numero + 1}. [{prioridad}] {descripcion} - {estado}");
    }
}

class ListaTareas
{
    private Tarea[] tareas = new Tarea[10];
    private int cantidad = 0;

    public void AgregarTarea(Tarea tarea)
    {
        if (cantidad < tareas.Length)
        {
            tareas[cantidad] = tarea;
            cantidad++;
            Console.WriteLine($"✓ Tarea agregada: {tarea.descripcion}");
        }
        else
        {
            Console.WriteLine("❌ Lista llena");
        }
    }

    public void CompletarTarea(int indice)
    {
        if (indice >= 0 && indice < cantidad)
        {
            tareas[indice].completada = true;
            Console.WriteLine($"✓ {tareas[indice].descripcion} completada");
        }
    }

    public void MostrarTareas()
    {
        for (int i = 0; i < cantidad; i++)
        {
            tareas[i].Mostrar(i);
        }
    }

    public void MostrarEstadisticas()
    {
        int completadas = 0;
        foreach (Tarea t in tareas)
        {
            if (t != null && t.completada)
                completadas++;
        }
        Console.WriteLine($"Total de tareas: {cantidad}");
        Console.WriteLine($"Completadas: {completadas}");
        Console.WriteLine($"Pendientes: {cantidad - completadas}");
    }
}
