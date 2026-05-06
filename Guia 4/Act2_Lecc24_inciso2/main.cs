using System;

class Programa
{
    static void Main()
    {
        int n;

        Console.WriteLine("Ingrese un número:");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            int resultado = n * i;
            Console.WriteLine(resultado);
        }
    }
}