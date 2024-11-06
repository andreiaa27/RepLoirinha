using System;

namespace numeros
{
    internal class ProgramL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero 3: ");
            double numero3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero 4: ");
            double numero4 = double.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
            {
                Console.WriteLine(numero1 + " é o maior número.");
            }
            else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
            {
                Console.WriteLine(numero2 + " é o maior número.");
            }
            else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
            {
                Console.WriteLine(numero3 + " é o maior número.");
            }
            else if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
            {
                Console.WriteLine(numero4 + " é o maior número.");
            }
            else
            {
                Console.WriteLine("os maiores números são repetidos");
            }

            Console.ReadKey();
        }
    }
}
