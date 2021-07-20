using System;
using PessoaMaisVelha;

namespace UtilizandoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa 1: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade da pessoa 1: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa 2: ");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade da pessoa 2: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());


            if (pessoa1.Idade == pessoa2.Idade)
            {
                Console.WriteLine("Pessoas tem a mesma Idade.", pessoa1.Nome);
            }
            else if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}.", pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}.", pessoa2.Nome);
            }
        }
    }
}
