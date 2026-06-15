/*
 * EJERCICIO: Validar Email
 * DESCRIPCIÓN: Verificar si un string tiene formato de email básico
 * CONCEPTOS: String.Contains(), String methods
 */

using System;

class ValidarEmail
{
    static void Main()
    {
        string email1 = "usuario@ejemplo.com";
        string email2 = "usuarioejemplo";
        string email3 = "test@gmail.com";

        ValidarYMostrar(email1);
        ValidarYMostrar(email2);
        ValidarYMostrar(email3);
    }

    static void ValidarYMostrar(string email)
    {
        // Validación básica: debe contener @ y .
        bool esValido = email.Contains("@") && email.Contains(".");

        // Validaciones adicionales
        if (esValido)
        {
            int posicionArroba = email.IndexOf("@");
            int posicionPunto = email.LastIndexOf(".");
            
            // El @ debe estar después de al menos 1 carácter
            // El . debe estar después del @
            esValido = posicionArroba > 0 && posicionPunto > posicionArroba + 1;
        }

        Console.WriteLine($"Email: {email} - Válido: {esValido}");
    }
}
