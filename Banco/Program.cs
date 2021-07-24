using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera depósito inicial (s/n): ");
            char depositoInicial = char.Parse(Console.ReadLine());

            if (depositoInicial == 's') { 
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());

                contaBancaria = new ContaBancaria(conta, titular, valor);
            }
            else
            {
                contaBancaria = new ContaBancaria(conta, titular);
            }
          
            MostrarDadosConta("Dados da conta:", contaBancaria);

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            contaBancaria.OperacaoFinaceira('D', valorDeposito);

            MostrarDadosConta("Dados da conta atualizados:", contaBancaria);

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            contaBancaria.OperacaoFinaceira('S', valorSaque);

            MostrarDadosConta("Dados da conta atualizados:", contaBancaria);
        }

        static void MostrarDadosConta(string msgInicial, ContaBancaria contaBancaria)
        {
            Console.WriteLine("");
            Console.WriteLine("{0}", msgInicial);
            Console.WriteLine("{0}", contaBancaria);
            Console.WriteLine("");
        }
    }
}
