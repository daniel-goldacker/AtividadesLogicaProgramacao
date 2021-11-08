using System;
namespace AutomatizacaoContrato.Servico
{
    public class ServicoPaypal : IServicoPagamentoOnline
    {
        private const double _percTaxaMensal = 1;
        private const double _percTaxaPagamento = 2;

        private double ValorTaxaMensal { get; set; }


        public double TaxaMensal(double valor, int mes)
        {
            return valor + (valor * (_percTaxaMensal / 100)) * mes; ;
        }

        public double TaxaPagamento(double valor)
        {
            return valor + (valor * (_percTaxaPagamento / 100));
        }
    }
}
