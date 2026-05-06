using System;
class Trigonometria
{
    static void Main()
    {
        Console.Write("Ingrese el ángulo en grados: ");
        double angulo = double.Parse(Console.ReadLine());

        double radianes = angulo * Math.PI / 180;

        Console.WriteLine("1. Seno\n2. Coseno\n3. Tangente");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(radianes));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(radianes));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(radianes));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}