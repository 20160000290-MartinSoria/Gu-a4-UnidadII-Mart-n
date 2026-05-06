/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Calculadora
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1: resultado = num1 + num2;
                break;
            case 2: resultado = num1 - num2;
                break;
            case 3: resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}