/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    double a, b, c;
    Console.WriteLine("Ingrese tres ángulos:");
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    c = double.Parse(Console.ReadLine());

    if (a + b + c == 180) {
      if (a == 60 && b == 60 && c == 60)
        Console.WriteLine("Equilátero");
      else if (a == b || a == c || b == c)
        Console.WriteLine("Isósceles");
      else
        Console.WriteLine("Escaleno");
    } else {
      Console.WriteLine("No válido");
    }
  }
}