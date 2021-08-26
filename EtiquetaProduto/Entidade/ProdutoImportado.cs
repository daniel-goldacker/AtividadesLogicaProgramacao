using System;
using System.Text;

namespace EtiquetaProduto.Entidade
{
    public class ProdutoImportado : Produto
    {

        public double TaxaAlfandegaria { get; set; }


        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandegaria) : base(nome, preco)
        {
            TaxaAlfandegaria = taxaAlfandegaria;
        }

        private double precoTotal()
        {
            return Preco + TaxaAlfandegaria;
        }

        public sealed override string PrecoEtiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" - R$ ");
            sb.Append(precoTotal().ToString());
            sb.Append(" (Taxa alfandegária R$ ");
            sb.Append(TaxaAlfandegaria);
            sb.Append(")");

            return sb.ToString();
        }


    }
}
