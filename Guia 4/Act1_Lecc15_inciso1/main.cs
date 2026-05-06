using System;

class Programa
{
    static void Main()
    {
        int tipo, totalBoletos = 0;
        double totalDinero = 0;

        do
        {
            Console.WriteLine("1=Adulto ($15), 2=Niño ($10), 0=Salir");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                totalBoletos++;
                totalDinero += 15;
            }
            else if (tipo == 2)
            {
                totalBoletos++;
                totalDinero += 10;
            }
            else if (tipo != 0)
            {
                Console.WriteLine("Opción inválida");
            }

        } while (tipo != 0);

        Console.WriteLine("Total de boletos: " + totalBoletos);
        Console.WriteLine("Total recaudado: $" + totalDinero);
    }
}