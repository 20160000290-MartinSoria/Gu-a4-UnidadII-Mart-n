using System;

class Programa
{
    static void Main()
    {
        int disponibles = 200;

        do
        {
            Console.WriteLine("Cajones disponibles: " + disponibles);
            disponibles--;
        }
        while (disponibles > 0);

        Console.WriteLine("Ya no hay cajones disponibles");
    }
}