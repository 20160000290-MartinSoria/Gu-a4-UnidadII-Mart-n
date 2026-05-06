using System;

class Programa
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 50; i++)
        {
            int divisores = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                suma += i;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);
    }
}