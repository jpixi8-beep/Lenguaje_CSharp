/*
 * EJERCICIO: Juego del Número Mágico
 * DESCRIPCIÓN: Adivina el número secreto generado aleatoriamente
 * CONCEPTOS: Random, while loop, condicionales
 */

using System;

class JuegoNumeroMagico
{
    static void Main()
    {
        Console.WriteLine("=== JUEGO DEL NÚMERO MÁGICO ===\n");
        Console.WriteLine("Debes adivinar un número entre 1 y 100");
        Console.WriteLine("Tendrás 10 intentos\n");

        Random random = new Random();
        int numeroSecrets = random.Next(1, 101);
        int intentos = 0;
        int maxIntentos = 10;
        bool adivinó = false;

        while (intentos < maxIntentos && !adivinó)
        {
            Console.Write($"Intento {intentos + 1}/{maxIntentos}: ");
            
            if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
            {
                if (numeroIngresado < 1 || numeroIngresado > 100)
                {
                    Console.WriteLine("❌ El número debe estar entre 1 y 100");
                    continue;
                }

                intentos++;

                if (numeroIngresado == numeroSecrets)
                {
                    Console.WriteLine($"\n🎉 ¡¡FELICIDADES!! ¡¡ADIVINASTE!!");
                    Console.WriteLine($"   El número era: {numeroSecrets}");
                    Console.WriteLine($"   Lo adivinaste en {intentos} intentos");
                    adivinó = true;
                }
                else if (numeroIngresado < numeroSecrets)
                {
                    Console.WriteLine($"📈 El número secreto es MAYOR que {numeroIngresado}");
                }
                else
                {
                    Console.WriteLine($"📉 El número secreto es MENOR que {numeroIngresado}");
                }

                Console.WriteLine($"Intentos restantes: {maxIntentos - intentos}\n");
            }
            else
            {
                Console.WriteLine("❌ Debes ingresar un número válido\n");
            }
        }

        if (!adivinó)
        {
            Console.WriteLine($"\n😢 Se acabaron los intentos");
            Console.WriteLine($"El número secreto era: {numeroSecrets}");
        }
    }
}
