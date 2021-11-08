using System;
using System.Collections.Generic;
using System.Globalization;

namespace AutomatizacaoContrato.Entidades
{
    class Contrato
    {
        public int  Numero { get; private set; }
        public DateTime Data { get; private set; }
        public double TotalValor { get; private set; }
        public List<Parcela> ListaParcelas { get; set; } = new List<Parcela>();
           

        public Contrato(int numero, DateTime data, double totalValor)
        {
            Numero = numero;
            Data = data;
            TotalValor = totalValor;
        }

        public void AdicionarParcela(Parcela parcela)
        {
            ListaParcelas.Add(parcela);
        }

        public void RemoverParcela(Parcela parcela)
        {
            ListaParcelas.Remove(parcela);
        }

        public override string ToString()
        {
            string mensagem = String.Empty;

            foreach (var item in ListaParcelas)
            {
                mensagem += "\n" + item.DataVencimento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " - " + item.Valor.ToString("F2", CultureInfo.InvariantCulture);
            }

            return mensagem;
        }
    }
}
