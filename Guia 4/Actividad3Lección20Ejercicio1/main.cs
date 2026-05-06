/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int dia;

    Console.WriteLine("Ingrese número del 1 al 7:");
    dia = int.Parse(Console.ReadLine());

    if (dia >= 1 && dia <= 5)
      Console.WriteLine("Entre semana");
    else if (dia == 6 || dia == 7)
      Console.WriteLine("Fin de semana");
    else
      Console.WriteLine("Inválido");
  }
}