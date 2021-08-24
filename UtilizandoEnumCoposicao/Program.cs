using System;
using System.Globalization;
using UtilizandoEnumCoposicao.Entidades;
using UtilizandoEnumCoposicao.Entidades.Enumeradores;
using UtilizandoEnumCoposicao.Entities;

namespace UtilizandoEnumCoposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do departamento: ");
            string departamento = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Informe os dados do trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível do trabalhador(Junior, Medio, Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.Write("Salário base: ");
            double salario = double.Parse(Console.ReadLine());

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salario, new Departamento(departamento));

            Console.WriteLine("");
            Console.Write("Quantos contratos serão cadastrados: ");
            int qtdContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdContratos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Informe os dados do contrato #{0}:", i);
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                Console.Write("Valor por hora: ");
                double valorHoras = double.Parse(Console.ReadLine());

                Console.Write("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                trabalhador.AdicionarContrato(new ContratoHoras(data, valorHoras, horas));
            }

            Console.WriteLine("");
            Console.Write("Informe o ano e o mês para calcular os contratos(MM/YYYY): ");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("");
            Console.WriteLine("Nome: {0}", trabalhador.Nome);
            Console.WriteLine("Departamento: {0}", trabalhador.Departamento.nome);
            Console.WriteLine("Renda {0}: {1}", mesAno, trabalhador.Renda(ano, mes));
        }
    }
}
