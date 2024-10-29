using System;

namespace salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Salario: ");
            int salario1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Salario: ");
            int salario2 = int.Parse(Console.ReadLine());

            double salarios = (salario1 + salario2) / 2;
            Console.WriteLine("A média dos salários é " + salarios);

            Console.ReadKey();
        }
    }
}
