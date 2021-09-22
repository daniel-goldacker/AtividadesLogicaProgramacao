using System;
using System.Collections.Generic;
using ImpostoPFePJ.Entidade;

namespace ImpostoPFePJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();

            Console.Write("Informe a qunatidade de pessoas: ");
            int qtdPessoas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdPessoas; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Pessoa #{0} dados: ", i);

                Console.Write("Pessoa Fisica(f) ou Pessoa Jurídica(j): ");
                string tipoPessoa = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipoPessoa == "F")
                {
                    Console.Write("Despesas com saúde: ");
                    double despesaSaude = double.Parse(Console.ReadLine());

                    listaPessoa.Add(new PessoaFisica(despesaSaude, nome, rendaAnual));
                } else if(tipoPessoa == "J"){

                    Console.Write("Quantidade de funcionários: ");
                    int qtdeEmpregados = int.Parse(Console.ReadLine());
                    listaPessoa.Add(new PessoaJuridica(qtdeEmpregados, nome, rendaAnual));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Total de Imposto");

            double totalImposto = 0;
            foreach (var item in listaPessoa)
            {
                Console.WriteLine(item.ToString());
                totalImposto += item.Imposto();
            }

            Console.WriteLine("");
            Console.WriteLine("Total de Imposto: R$ {0}", totalImposto.ToString("F2"));
        }
    }
}
