using System;
namespace UtilizandoHeranca.Entidades
{
    sealed class ContaPoupanca : Conta // classe seladas não permite ela ter filhos
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        //  base(numero, titular, saldo) - Chama o construtor da superclasse (Conta)
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }


        public void AtualizarSaldoConta()
        {
            Saldo += Saldo * TaxaJuros;
        }

        // Apenas métodos com override podem ser sealed
        public sealed override void Saque(double valor)
        {
            base.Saque(valor); // base chama o o método ca classe pai.
            Saldo -= valor;
        }
    }
}
