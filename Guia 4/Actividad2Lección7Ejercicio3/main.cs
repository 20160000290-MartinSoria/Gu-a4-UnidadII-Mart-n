/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int mes;

    Console.WriteLine("Ingrese número del mes:");
    mes = int.Parse(Console.ReadLine());

    if (mes == 1) Console.WriteLine("Enero");
    else if (mes == 2) Console.WriteLine("Febrero");
    else if (mes == 3) Console.WriteLine("Marzo");
    else if (mes == 4) Console.WriteLine("Abril");
    else if (mes == 5) Console.WriteLine("Mayo");
    else if (mes == 6) Console.WriteLine("Junio");
    else if (mes == 7) Console.WriteLine("Julio");
    else if (mes == 8) Console.WriteLine("Agosto");
    else if (mes == 9) Console.WriteLine("Septiembre");
    else if (mes == 10) Console.WriteLine("Octubre");
    else if (mes == 11) Console.WriteLine("Noviembre");
    else if (mes == 12) Console.WriteLine("Diciembre");
    else Console.WriteLine("Inválido");
  }
}