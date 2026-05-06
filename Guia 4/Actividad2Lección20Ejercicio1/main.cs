/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    string clave;
    Console.WriteLine("Ingrese contraseña:");
    clave = Console.ReadLine();

    if (clave == "Password123")
      Console.WriteLine("Bienvenido");
    else
      Console.WriteLine("Ingreso prohibido");
  }
}