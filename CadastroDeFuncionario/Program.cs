using System;
using System.Collections.Generic;

namespace CadastroDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de funcionários a ser registrado: ");
            int qtdFunReg = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            for (int i = 1; i <= qtdFunReg; i++)
            {
                Console.WriteLine("");

                Console.Write("Id: ");
                int idFunc = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nomeFun = Console.ReadLine();

                Console.Write("Salário: ");
                double salarioFun = double.Parse(Console.ReadLine());

                listaFuncionario.Add(new Funcionario(idFunc, nomeFun, salarioFun));
            }

            Console.WriteLine("");
            Console.Write("Informe o id do funcionário que receberá aumento: ");
            int idFuncAumento = int.Parse(Console.ReadLine());

            int posicaoIdFunc = listaFuncionario.FindIndex(x => x.Id == idFuncAumento);

            if (posicaoIdFunc >= 0)
            {
                Console.Write("% de Aumento: ");
                double percAumento = double.Parse(Console.ReadLine());

                listaFuncionario[posicaoIdFunc].AlterarSalario(Funcionario.CalculaAumentoSalario(percAumento, listaFuncionario[posicaoIdFunc].Salario));
            }
            else
            { 
                Console.WriteLine("");
                Console.WriteLine("Funcionário não existe!");
            }

            Console.WriteLine("");
            Console.WriteLine("Lista de Funcionários: ");
            foreach (var item in listaFuncionario)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
