using System;

class Evaluacion
{
    static void Main()
    {
        Console.Write("Ingrese una letra (A, B, C, D, F): ");
        char letra = char.ToUpper(Console.ReadLine()[0]);

        switch (letra)
        {
            case 'A': Console.WriteLine("Excelente");
            break;
            case 'B': Console.WriteLine("Bueno");
            break;
            case 'C': Console.WriteLine("Regular");
            break;
            case 'D': Console.WriteLine("Deficiente");
            break;
            case 'F': Console.WriteLine("Reprobado");
            break;
            default: Console.WriteLine("Letra inválida");
            break;
        }
    }
}