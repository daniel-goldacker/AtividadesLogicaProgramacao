using System;
using System.Collections.Generic;
using FuncionarioHorasTrabalhadas.Entidades;

namespace FuncionarioHorasTrabalhadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de funcionarios para cadastrar: ");
            int qtdFuncionario = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionario = new List<Funcionario>();
     

            for (int i = 1; i <= qtdFuncionario; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Dados do funcionário #{0}:", i);

                Console.Write("Terceiro (S/N): ");
                string terceiro = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor horas: ");
                double valorHora = double.Parse(Console.ReadLine());

                if (terceiro == "S")
                {
                    Console.Write("Valor Adicional: ");
                    double valorAdicional = double.Parse(Console.ReadLine());

                    listaFuncionario.Add(new FuncionarioTerceiro(nome, horas, valorHora, valorAdicional));
                }
                else
                {
                    listaFuncionario.Add(new Funcionario(nome, horas, valorHora));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Pagamentos: ");
            foreach (var item in listaFuncionario)
            {
                Console.Write(item.ToString());
            }
        }
    }
}
