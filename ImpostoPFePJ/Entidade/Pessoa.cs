using System;
namespace ImpostoPFePJ.Entidade
{
    abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected double RendaAnual { get; set; }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
