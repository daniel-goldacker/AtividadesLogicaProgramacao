using System;
using System.Collections.Generic;

namespace UtilizandoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNomes = new List<string>();

            listaNomes.Add("daniel");
            listaNomes.Add("bruna");
            listaNomes.Add("bianca");
            listaNomes.Add("marcos");
            listaNomes.Add("diego");
            listaNomes.Add("leonardo");
            listaNomes.Add("bernardo");
            listaNomes.Add("drika");
            listaNomes.Add("driko");

            if (listaNomes.Count == 0) { 
                string nome = string.Empty;
            
                while (nome.ToUpper() != "FIM")
                {
                    if (!nome.Equals(string.Empty))
                    {
                        listaNomes.Add(nome);
                        /* .Add(valor) - Adiciona sempre na ultima posição
                         * .Insert(posicao, valor) - Adiciona na posição do parâmetro, empurrando os registros da lista para baixo */
                    }

                    Console.Write("Digite um nome (fim para terminar): ");
                    nome = Console.ReadLine();
                }
            }

            if (listaNomes.Count > 0)
            {
                 
                //listaNomes.Remove("drika"); // remove da lista por item
                //listaNomes.RemoveAt(7); // remove da lista por index
                listaNomes.RemoveRange(2, 2); // remove da lista à partir do index, tantas posições

                Console.WriteLine("");
                Console.WriteLine("Lista de Nomes: ");
                foreach (var item in listaNomes)
                {
                    Console.WriteLine("* Nome: {0}", item);
                }

                List<string> listaPessoas = listaNomes.FindAll(x => x[0] == 'D' || x[0] == 'd');
                if (listaPessoas.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Lista de Nomes (Começam com D): ");
                    foreach (var item in listaPessoas)
                    {
                        Console.WriteLine("* Nome: {0}", item);
                    }
                }

                // o comando x => x[0] == 'B' || x[0] == 'b' é uma expressão lambda
                Console.WriteLine("");
                string primeiroNome = listaNomes.Find(x => x[0] == 'B' || x[0] == 'b');
                int primeiraPosicao = listaNomes.FindIndex(x => x[0] == 'B' || x[0] == 'b');

                string ultimoNome = listaNomes.FindLast(x => x[0] == 'B' || x[0] == 'b');
                int ultimaPosicao = listaNomes.FindLastIndex(x => x[0] == 'B' || x[0] == 'b');

                Console.WriteLine("Primeira nome com a letra 'B' é {0} na posição: {1}", primeiroNome, primeiraPosicao);
                Console.WriteLine("Último nome com a letra 'B' é {0} na posição: {1}", ultimoNome, ultimaPosicao);

              
            }
        }
    }
}
