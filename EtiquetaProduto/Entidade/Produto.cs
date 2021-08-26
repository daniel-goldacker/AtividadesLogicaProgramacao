using System;
using System.Text;

namespace EtiquetaProduto.Entidade
{
    public class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" - R$ ");
            sb.Append(Preco.ToString());

            return sb.ToString();
        }
    }
}
