using System;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const double pi = Math.PI;
            Console.WriteLine("Introduza o raio: ");
            double raio1 = double.Parse(Console.ReadLine());

            double area = pi * (raio1 * raio1);

            Console.WriteLine("A área do círculo é: {0:F4} ", area);

            Console.ReadKey();
        }
    }
}
