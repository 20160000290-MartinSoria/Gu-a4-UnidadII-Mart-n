/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int dia, mes;

    Console.WriteLine("Ingrese día:");
    dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese mes:");
    mes = int.Parse(Console.ReadLine());

    if ((mes == 12 && dia >= 21) || mes == 1 || mes == 2 || (mes == 3 && dia <= 20))
      Console.WriteLine("Invierno");
    else if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia <= 20))
      Console.WriteLine("Primavera");
    else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia <= 20))
      Console.WriteLine("Verano");
    else
      Console.WriteLine("Otoño");
  }
}