using System;
namespace AdicionarVetoresClasse
{
    public class Produto
    {
        private string Nome { get; set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
