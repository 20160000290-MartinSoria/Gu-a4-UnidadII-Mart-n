using System;

class Programa
{
    static void Main()
    {
        for (int corte = 1; corte <= 8; corte++)
        {
            Console.WriteLine("Corte número: " + corte);
        }

        Console.WriteLine("¡Has llegado a 8 sellos!");
        Console.WriteLine("Tu próximo corte es GRATIS");
    }
}