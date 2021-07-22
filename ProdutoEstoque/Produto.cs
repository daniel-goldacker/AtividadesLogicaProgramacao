﻿using System;
namespace ProdutoEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Estoque;
        public string UnidadeMedida;

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
            Nome = nome;
            this.Preco = Preco;
            /* O this nesse caso quer dizer que estou me referindo ao atributo "Preco" da classe pois nesse exemplo o nome do parâmetro 
             * do costrutor tem o mesmo nome do atributo da classe */
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
