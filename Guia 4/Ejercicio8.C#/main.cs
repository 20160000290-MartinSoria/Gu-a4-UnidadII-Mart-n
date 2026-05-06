using System;
class Estadio
{
    static void Main()
    {
        Console.WriteLine("Seleccione el sector:");
        Console.WriteLine("1. Palco (Q300)");
        Console.WriteLine("2. Tribuna (Q112.5)");
        Console.WriteLine("3. Preferencia (Q62.5)");
        Console.WriteLine("4. Generales (Q40)");
        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de entradas: ");
        int cantidad = int.Parse(Console.ReadLine());

        double precio = 0;

        switch (opcion)
        {
            case 1: precio = 300;
                break;
            case 2: precio = 112.5;
                break;
            case 3: precio = 62.5;
                break;
            case 4: precio = 40;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        double total = precio * cantidad;
        Console.WriteLine("Total a pagar: Q" + total);
    }
}