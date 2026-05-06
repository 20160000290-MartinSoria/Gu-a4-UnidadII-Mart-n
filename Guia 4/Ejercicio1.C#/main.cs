/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class DiaSemana
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1: Console.WriteLine("Lunes");
                break;
            case 2: Console.WriteLine("Martes");
                break;
            case 3: Console.WriteLine("Miércoles");
                break;
            case 4: Console.WriteLine("Jueves");
                break;
            case 5: Console.WriteLine("Viernes");
                break;
            case 6: Console.WriteLine("Sábado");
                break;
            case 7: Console.WriteLine("Domingo");
                break;
            default: Console.WriteLine("Número inválido");
                break;
        }
    }
}