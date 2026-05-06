internal class Program
{
    private static void Main(string[] args)
    {
        double peso, total = 0;

        Console.WriteLine("Simulación: Comprar 1 kg de manzanas");

        while (total < 1)
        {
            Console.Write("Ingrese el peso de la manzana (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            total += peso;
            Console.WriteLine("Peso acumulado: " + total + " kg");
        }

        Console.WriteLine("¡Ya tienes 1 kilogramo de manzanas!");
    }
}