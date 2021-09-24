using System;
using ContaBancara.Entidade.Excecao;

namespace ContaBancara.Entidade
{
    public class Conta
    {

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteRetirada { get; set; }

        public Conta(int numero, string titular, double saldo, double limiteRetirada)
        {
            Numero = numero;
            Titular = titular;
            LimiteRetirada = limiteRetirada;

            Deposito(saldo);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {

            if (Saldo < valor)
            {
                throw new DominioExcecao("Não existe saldo suficiente em conta para relizar o saque.");
            }

            if (valor > LimiteRetirada)
            {
                throw new DominioExcecao("Saque não pode ser maior que o limite de saque.");
            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Novo Saldo: R$ " + Saldo;
        }
    }
}
