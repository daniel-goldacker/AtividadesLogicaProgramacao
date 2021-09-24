using System;
using ContaBancara.Entidade;
using ContaBancara.Entidade.Excecao;

namespace ContaBancara
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe os dados da conta: ");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Write("Limite de Saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.Write("Informe o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                Conta conta = new Conta(numero, titular, saldo, limiteSaque);

                conta.Saque(valorSaque);

                Console.WriteLine(conta.ToString());
            }
            catch(DominioExcecao e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Formato inválido!");
            }catch(Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
        }
    }
}
