using System;

class Conversor
{
    static void Main()
    {
        Console.WriteLine("Unidad de origen:");
        Console.WriteLine("1. Metros\n2. Pies\n3. Centímetros\n4. Pulgadas");
        int origen = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        double valor = double.Parse(Console.ReadLine());

        double metros = 0;

        switch (origen)
        {
            case 1: metros = valor;
                break;
            case 2: metros = valor * 0.3048;
                break;
            case 3: metros = valor / 100;
                break;
            case 4: metros = valor * 0.0254;
                break;
        }

        Console.WriteLine("Convertir a:");
        Console.WriteLine("1. Metros\n2. Pies\n3. Centímetros\n4. Pulgadas");
        int destino = int.Parse(Console.ReadLine());

        double resultado = 0;

        switch (destino)
        {
            case 1: resultado = metros;
                break;
            case 2: resultado = metros / 0.3048;
                break;
            case 3: resultado = metros * 100;
                break;
            case 4: resultado = metros / 0.0254;
                break;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}