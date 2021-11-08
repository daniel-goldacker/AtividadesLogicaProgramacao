using System;
using System.Globalization;
using AutomatizacaoContrato.Entidades;

namespace AutomatizacaoContrato.Servico
{
   class ServicoProcessarParcela
    {
        private IServicoPagamentoOnline _taxaServico;

        public ServicoProcessarParcela(IServicoPagamentoOnline taxaServico)
        {
            _taxaServico = taxaServico;
        }

        public void ProcessarParcelas(Contrato contrato, int numeroParcela) {


            for (int i = 1; i <= numeroParcela; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valor = contrato.TotalValor / numeroParcela;

                valor = _taxaServico.TaxaMensal(valor, i);
                valor = _taxaServico.TaxaPagamento(valor);

                contrato.AdicionarParcela(new Parcela(data, valor));
            }
        }
    }
}
