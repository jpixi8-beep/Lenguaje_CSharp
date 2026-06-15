/*
 * EJERCICIO: Delegates y Eventos
 * DESCRIPCIÓN: Usar delegates para callbacks y eventos
 * CONCEPTOS: Delegates, event, suscripción
 */

using System;

class DelegatesyEventos
{
    static void Main()
    {
        Console.WriteLine("=== DELEGATES Y EVENTOS ===\n");

        Boton boton = new Boton("Click Me");

        // Suscribirse a eventos
        boton.OnClick += ManejarClick;
        boton.OnClick += OtroManejador;

        // Simular clicks
        boton.Click();
        Console.WriteLine();
        boton.Click();
    }

    static void ManejarClick()
    {
        Console.WriteLine("✓ ¡El botón fue clickeado!");
    }

    static void OtroManejador()
    {
        Console.WriteLine("✓ Otro manejador respondiendo");
    }
}

class Boton
{
    public string nombre;
    
    // Definir un delegate
    public delegate void ClickEventHandler();
    
    // Definir un evento basado en el delegate
    public event ClickEventHandler OnClick;

    public Boton(string nombre)
    {
        this.nombre = nombre;
    }

    public void Click()
    {
        Console.WriteLine($"[{nombre}] Siendo presionado...");
        OnClick?.Invoke();
    }
}
