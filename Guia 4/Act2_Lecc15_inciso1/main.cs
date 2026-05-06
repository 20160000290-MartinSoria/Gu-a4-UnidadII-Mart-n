using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Números y suma de números primos de 100");
        int contador = 0;
        int suma = 0;

        for (int i = 1; i <= 100; i++)
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
                contador++;
                suma += i;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + contador);
        Console.WriteLine("Suma de los números primos: " + suma);
    }
}