using System;

class Programa
{
    static void Main()
    {
        int n;
        long factorial = 1;

        Console.WriteLine("Ingrese un número:");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial es: " + factorial);
    }
}