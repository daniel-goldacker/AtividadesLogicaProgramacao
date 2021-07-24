using System;
namespace ProdutoEstoque
{
    public class Produto
    {
        // Atributos como variáveis (Privadas para não ser acessadas fora da classe)
        private string _nome;
        public double Preco { get; set; }
        public double Estoque { get; set; }
        public string UnidadeMedida { get; private set; }


        // Atributos como propriedades (Tornando acessiverl as variáveis acima fora da classe)
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // Construtor padrão
        public Produto()
        {
        }

        // Construtor com inicialização
        public Produto(string nome, double preco, double estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        // construtor com sobrecarga de método
        public Produto(string nome, double Preco)
        {
            _nome = nome;
            this.Preco = Preco;
            /* O this nesse caso quer dizer que estou me referindo ao atributo "Preco" da classe */
        }

        // construtor com sobrecarga de método - usando o this de outro construtor da classe para preencher os campos.
        public Produto(string nome, double preco, double estoque, string unidadeMedida): this(nome, preco, estoque)
        {
            UnidadeMedida = unidadeMedida;
        }

        private double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2") + ", " + Estoque + " unidades, Total R$ " + ValorTotalEmEstoque().ToString("F2");
        }

        public void AdicionarProdutos(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }
    }
}
