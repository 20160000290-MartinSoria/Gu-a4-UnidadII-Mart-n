using System;

class Programa
{
    static void Main()
    {
        int tipo, totalBoletos = 0;
        double totalDinero = 0;

        do
        {
            Console.WriteLine("Ingrese tipo: 1=Niño ($10), 2=Adulto ($15), 0=Salir");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                totalBoletos++;
                totalDinero += 10;
            }
            else if (tipo == 2)
            {
                totalBoletos++;
                totalDinero += 15;
            }
            else if (tipo != 0)
            {
                Console.WriteLine("Opción inválida");
            }

            if (tipo != 0)
            {
                Console.WriteLine("Boletos vendidos: " + totalBoletos);
                Console.WriteLine("Total cobrado: $" + totalDinero);
            }

        } while (tipo != 0);

        Console.WriteLine("Venta finalizada");
    }
}