/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class HelloWorld
{
    static void Main()
    {
        double peso = 0;
        double total = 0;

        while (total < 1000)
        {
            Console.WriteLine("Ingrese el peso de la manzana en gramos:");
            peso = Convert.ToDouble(Console.ReadLine());

            total += peso;

            Console.WriteLine("Peso acumulado: " + total + " gramos");
        }

        Console.WriteLine("Ya tienes 1 kilo o más de manzanas.");
    }
}