using System;

namespace ControlePensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de quartos a ser alugado: ");
            int qtdQrtAlugar = int.Parse(Console.ReadLine());

            Quarto[] listaQuartos = new Quarto[10];

            for (int i = 0; i < qtdQrtAlugar; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Quarto #{0}:", i+1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                listaQuartos[quarto-1] = new Quarto(quarto, nome, email);
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos Alugados:");
            for (int i = 0; i < listaQuartos.Length; i++)
            {
                if (listaQuartos[i] != null)
                {
                    Console.WriteLine("{0}: {1}, {2}", listaQuartos[i].Numero, listaQuartos[i].Nome, listaQuartos[i].Email);
                }
            }
        }
    }
}
