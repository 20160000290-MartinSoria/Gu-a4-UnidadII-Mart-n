using System;

class Programa
{
    static void Main()
    {
        int n1, n2, menor, mayor, suma = 0;

        Console.WriteLine("Ingrese el primer número:");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 < n2)
        {
            menor = n1;
            mayor = n2;
        }
        else
        {
            menor = n2;
            mayor = n1;
        }

        for (int i = menor; i <= mayor; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}