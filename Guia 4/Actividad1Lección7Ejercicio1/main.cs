/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Ejercicio2 {
  static void Main() {
    int edad;

    Console.WriteLine("Ingrese su edad:");
    edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
      Console.WriteLine("Mayor de edad");
    else
      Console.WriteLine("Menor de edad");
  }
}