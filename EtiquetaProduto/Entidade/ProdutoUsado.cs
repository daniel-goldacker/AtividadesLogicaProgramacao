using System;
using System.Text;

namespace EtiquetaProduto.Entidade
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataProducao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataProducao) : base(nome, preco) 
        {
            DataProducao = dataProducao;
        }

        public override string PrecoEtiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" (Usado) R$ ");
            sb.Append(Preco.ToString());
            sb.Append(" (Data produção: ");
            sb.Append(DataProducao.ToString("dd/MM/yyyy"));
            sb.Append(")");
            return sb.ToString();
        }
    }
}
