using System;

class Programa
{
    static void Main()
    {
        int n, contador = 0;

        Console.WriteLine("Ingrese un número:");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("El número es primo");
        }
        else
        {
            Console.WriteLine("El número no es primo");
        }
    }
}