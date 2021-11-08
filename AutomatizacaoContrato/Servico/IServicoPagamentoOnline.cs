using System;
namespace AutomatizacaoContrato.Servico
{
    interface IServicoPagamentoOnline
    {
        double TaxaMensal(double valor, int mes);
        double TaxaPagamento(double valor);
    }
}
