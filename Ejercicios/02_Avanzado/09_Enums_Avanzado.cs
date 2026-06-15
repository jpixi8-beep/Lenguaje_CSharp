/*
 * EJERCICIO: Enums Avanzado
 * DESCRIPCIÓN: Usar enums para tipos de datos definidos
 * CONCEPTOS: Enums, switch, validación
 */

using System;

class EnumsAvanzado
{
    static void Main()
    {
        Console.WriteLine("=== ENUMS AVANZADO ===\n");

        // Usar enums
        Producto producto = new Producto("Laptop", Categoria.Electrónica, Estado.Disponible);
        producto.MostrarInfo();

        Console.WriteLine("\n--- Cambiar estado ---");
        producto.CambiarEstado(Estado.Agotado);
        producto.MostrarInfo();

        // Listar todas las categorías
        Console.WriteLine("\n--- Categorías disponibles ---");
        foreach (Categoria cat in Enum.GetValues(typeof(Categoria)))
        {
            Console.WriteLine($"- {cat}");
        }
    }
}

enum Categoria
{
    Electrónica,
    Ropa,
    Alimentos,
    Libros,
    Deportes
}

enum Estado
{
    Disponible,
    Agotado,
    Descontinuado,
    Préstamo
}

class Producto
{
    public string nombre;
    public Categoria categoria;
    public Estado estado;

    public Producto(string nombre, Categoria categoria, Estado estado)
    {
        this.nombre = nombre;
        this.categoria = categoria;
        this.estado = estado;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto: {nombre}");
        Console.WriteLine($"Categoría: {categoria}");
        Console.WriteLine($"Estado: {estado}");
        Console.WriteLine($"Disponible: {EstaDisponible()}");
    }

    public void CambiarEstado(Estado nuevoEstado)
    {
        estado = nuevoEstado;
        Console.WriteLine($"Estado actualizado a: {estado}");
    }

    public bool EstaDisponible()
    {
        return estado == Estado.Disponible;
    }
}
