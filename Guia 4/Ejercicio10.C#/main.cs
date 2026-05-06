using System;

class Impresoras
{
    static void Main()
    {
        Console.Write("Cantidad de impresoras: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");
        int opcion = int.Parse(Console.ReadLine());
        double precioUnitario = 650;
        double iva = 0.12;

        double precioConIVA = precioUnitario + (precioUnitario * iva);
        double totalSinDescuento = precioConIVA * cantidad;

        double descuento = 0;
        string forma = "";

        switch (opcion)
        {
            case 1: descuento = 0.10;
                    forma = "Efectivo";
                break;
            case 2: descuento = 0.05;
                    forma = "Tarjeta de crédito";
                break;
            case 3: descuento = 0.15;
                    forma = "Vale de regalo";
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        double montoDescuento = totalSinDescuento * descuento;
        double totalPagar = totalSinDescuento - montoDescuento;

        Console.WriteLine("\n--- DETALLE ---");
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio con IVA: Q" + precioConIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + forma);
        Console.WriteLine("Descuento: Q" + montoDescuento);
        Console.WriteLine("Total a pagar: Q" + totalPagar);
    }
}