using System;
using System.Diagnostics.Eventing.Reader;

namespace idade_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
           string nome1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.WriteLine(nome2 + " é mais velho");
            }
            else if (idade1 == idade2)
            {
                Console.WriteLine(nome1 + " e " + nome2 + " têm a mesma idade");
            }
            else
            {
                Console.WriteLine(nome1 + " é mais velho");
            }
            Console.ReadKey();
            






        }
    }
}
