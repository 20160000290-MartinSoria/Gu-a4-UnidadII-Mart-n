/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Ejercicio {
  static void Main() {
    double nota;

    Console.WriteLine("Ingrese la nota:");
    nota = double.Parse(Console.ReadLine());

    if (nota < 60)
      Console.WriteLine("Deficiente");
    else if (nota < 70)
      Console.WriteLine("Regular");
    else if (nota < 80)
      Console.WriteLine("Bien");
    else if (nota < 90)
      Console.WriteLine("Muy bien");
    else
      Console.WriteLine("Excelente");
  }
}