using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Sumatoria y cantidad de pares de 7");
        int suma = 0;
        int contadorPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            int multiplo = 7 * i;

            suma += multiplo;

            if (multiplo % 2 == 0)
            {
                contadorPares++;
            }
        }

        Console.WriteLine("Sumatoria: " + suma);
        Console.WriteLine("Cantidad de pares: " + contadorPares);
    }
}