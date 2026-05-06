using System;

class Programa
{
    static void Main()
    {
        int n;

        Console.WriteLine("Ingrese un número:");
        n = Convert.ToInt32(Console.ReadLine());

        if (n >= 2)
        {
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("El número debe ser mayor o igual a 2");
        }
    }
}