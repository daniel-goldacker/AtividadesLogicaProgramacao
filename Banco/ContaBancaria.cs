using System;
namespace Banco
{
    public class ContaBancaria
    {
        private readonly int _taxaSaque = 5;
        private int Conta { get; set; }
        private string Titular { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria(int conta, string Titular)
        {
            Conta = conta;
            this.Titular = Titular;
        }

        public ContaBancaria(int conta, string Titular, double depositoInicial): this(conta, Titular)
        { 
            OperacaoFinaceira('D', depositoInicial);
        }

        public void OperacaoFinaceira(char operacao, double valor)
        {
            if (valor > 0)
            {
                if (operacao == 'D')
                {
                    Saldo += valor;
                }
                else if (operacao == 'S')
                {
                    Saldo -= (valor + _taxaSaque);
                }
            }
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2");
        }
    }
}
