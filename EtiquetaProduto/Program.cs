using System;
using System.Collections.Generic;
using System.Globalization;
using EtiquetaProduto.Entidade;

namespace EtiquetaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int qtdProduto = int.Parse(Console.ReadLine());

            List<Produto> listaProduto = new List<Produto>();

            for (int i = 1; i <= qtdProduto; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Dados do produto #{0}", i);
                Console.Write("Produto é importando, comum  ou usado (i, c, u): ");
                string tipoProduto = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (tipoProduto == "I")
                {
                    Console.Write("Taxa alfandegária: ");
                    double taxaAlfandegaria = double.Parse(Console.ReadLine());

                    listaProduto.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
                } else if(tipoProduto == "U")
                {
                    Console.Write("Data produção: ");
                    DateTime dataProducao = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                    listaProduto.Add(new ProdutoUsado(nome, preco, dataProducao));
                }
                else
                {
                    listaProduto.Add(new Produto(nome, preco));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Preço TAGs");
            foreach (var item in listaProduto)
            {
                Console.WriteLine(item.PrecoEtiqueta());
            }
        }
    }
}
