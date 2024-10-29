using System;

namespace peças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo Peça1: ");
            string codigo1 = Console.ReadLine();
            Console.WriteLine("Quantidade Peça1: ");
            int quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço Peça1: ");
            double preco1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Codigo Peça2: ");
            string codigo2 = Console.ReadLine();
            Console.WriteLine("Quantidade Peça2: ");
            int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço Peça2: ");
            double preco2 = double.Parse(Console.ReadLine());

            double total1 = quantidade1 * preco1;
            double total2 = quantidade2 * preco2;


            double total = total1 + total2;
            Console.WriteLine("O valor a pagar pelas peças é " + total);

            Console.ReadKey();
        }
    }
}
