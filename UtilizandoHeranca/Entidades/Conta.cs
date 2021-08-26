using System;
namespace UtilizandoHeranca.Entidades
{
    public class Conta
    {
        private int Numero { get; set; }
        private string Titular { get; set; }
        public double Saldo { get; protected set; }

        // private - Permite alterar apenas na própria classe;
        // protected - Permite alterar apenas na própria classe e na classe filha;

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;

            Deposito(Saldo);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }


        // Para subscrever o método em uma classe filha tem que usar virtual na classe pai.
        public virtual void Saque(double valor)
        {
            Saldo -= valor + 5;
        }
    }
}
