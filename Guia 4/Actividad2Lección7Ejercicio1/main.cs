/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Ejercicio3 {
  static void Main() {
    int opcion;

    Console.WriteLine("1. Ventas");
    Console.WriteLine("2. Soporte");
    Console.WriteLine("3. Facturación");
    Console.WriteLine("4. Operador");
    Console.WriteLine("Elija una opción");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
      Console.WriteLine("Ventas");
    else if (opcion == 2)
      Console.WriteLine("Soporte");
    else if (opcion == 3)
      Console.WriteLine("Facturación");
    else if (opcion == 4)
      Console.WriteLine("Operador");
    else
      Console.WriteLine("Opción inválida");
  }
}