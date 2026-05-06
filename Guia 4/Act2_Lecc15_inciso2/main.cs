using System;

class Programa
{
    static void Main()
    {
        int contador100 = 0;
        int totalDinero = 0;

        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine("Ingrese el valor del billete (20, 50, 100):");
            int billete = Convert.ToInt32(Console.ReadLine());

            totalDinero += billete;

            if (billete == 100)
            {
                contador100++;
            }
        }

        Console.WriteLine("Cantidad de billetes de $100: " + contador100);
        Console.WriteLine("Total de dinero: $" + totalDinero);
    }
}