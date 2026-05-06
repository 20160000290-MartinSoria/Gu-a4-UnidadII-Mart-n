using System;
class TipoCaracter
{
    static void Main()
    {
        Console.Write("Ingrese un carácter: ");
        char c = Console.ReadLine()[0];

        if ("aeiouAEIOU".Contains(c))
        {
            Console.WriteLine("Es una vocal");
        }
        else if (char.IsDigit(c))
        {
            Console.WriteLine("Es un dígito");
        }
        else
        {
            Console.WriteLine("No es vocal ni dígito");
        }
    }
}