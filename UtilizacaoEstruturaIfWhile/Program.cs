using System;

namespace EstruturaIfWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = DateTime.Now.Year;

            while (ano != 0000)
            { 
                Console.WriteLine("Informe um ano (0000 para terminar): ");
                ano = int.Parse(Console.ReadLine());

                if (AnoEhAtual(ano))
                {
                    Console.WriteLine("O ano de {0} é o ano atual.", ano);
                } else
                {
                    Console.WriteLine("O ano de {0} não é o ano atual.", ano);
                }
                Console.WriteLine("");
            }
        }


        static bool AnoEhAtual(int ano)
        {
            bool anoAtual = false;

            if (ano == DateTime.Now.Year)
            {
                anoAtual = true;
            }

            return anoAtual;
        }
    }
}
