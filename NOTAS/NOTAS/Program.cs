using System;

namespace NOTAS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nota:");
           double nota = double.Parse(Console.ReadLine());

            if (nota <= 5) {
                Console.WriteLine("Muito Insuficiente");
            }
            else if (nota <= 9.5) {
                Console.WriteLine("Insuficiente");
            }
            else if (nota > 9.5  && nota < 15) {
                Console.WriteLine("Suficiente");
            }
            else
            {
                Console.WriteLine("Bom");
            }
            Console.ReadKey();
        }
    }
}
