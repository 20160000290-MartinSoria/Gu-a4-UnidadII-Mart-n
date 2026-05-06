using System;

class Juego
{
    static void Main()
    {
        int monedas;

        Console.WriteLine("Ingrese la cantidad de monedas del jugador:");
        monedas = Convert.ToInt32(Console.ReadLine());

        if (monedas >= 350)
        {
            Console.WriteLine("Nivel 5 desbloqueado. Puedes ingresar.");
        }
        else
        {
            Console.WriteLine("Nivel 5 bloqueado. Necesitas al menos 350 monedas.");
        }
    }
}