using System;

class Programa
{
    static void Main()
    {
        int n, suma = 0;

        Console.WriteLine("Ingrese un número:");
        n = Convert.ToInt32(Console.ReadLine());

        while (n >= 1)
        {
            Console.WriteLine(n);
            suma += n;
            n--;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}