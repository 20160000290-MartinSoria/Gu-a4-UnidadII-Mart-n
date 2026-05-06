using System;

class Programa
{
    static void Main()
    {
        int contadorPrimos = 0;
        int sumaPares = 0;

        for (int i = 300; i >= 1; i--)
        {
            int divisores = 0;

            // Verificar si es primo
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                contadorPrimos++;
            }

            // Verificar si es par
            if (i % 2 == 0)
            {
                sumaPares += i;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + contadorPrimos);
        Console.WriteLine("Suma de números pares: " + sumaPares);
    }
}