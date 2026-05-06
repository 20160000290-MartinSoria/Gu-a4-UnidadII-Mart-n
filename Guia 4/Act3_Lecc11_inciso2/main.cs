using System;
class Programa
{
    
    static void Main()
    {
        int num, suma = 0;
        do
        
        {
            Console.WriteLine("Ingrese un número:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 9)
            {
                suma += num;
            }
        } while (num != 9);
        Console.WriteLine("La suma total es: " + suma);
    }
}