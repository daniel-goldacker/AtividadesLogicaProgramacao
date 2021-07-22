using System;
namespace ProdutoEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Estoque;

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
