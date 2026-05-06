using System;

class Programa
{
    static void Main()
    {
        double peso, total = 0;

        do
        {
            Console.WriteLine("Ingrese el peso de la manzana en gramos:");
            peso = Convert.ToDouble(Console.ReadLine());

            total += peso;

            Console.WriteLine("Peso acumulado: " + total + " gramos");

        } while (total < 1000);

        Console.WriteLine("¡Ya tienes 1 kilo o más de manzanas!");
    }
}