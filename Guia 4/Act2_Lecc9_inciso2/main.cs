using System;

class Programa
{
    static void Main()
    {
        int n;

        Console.WriteLine("Ingrese un número del 20 en adelante:");
        n = Convert.ToInt32(Console.ReadLine());

        if (n >= 20)
        {
            for (int i = 21; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Ingrese un número válido");
        }
    }
}