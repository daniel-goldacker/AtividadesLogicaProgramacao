using System;
namespace ImpostoPFePJ.Entidade
{
    class PessoaFisica : Pessoa
    {
        public double DespesaSaude { get; set; }

        public PessoaFisica(double despesaSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            DespesaSaude = despesaSaude;
        }

        public override double Imposto()
        {
            double valorImposto = 0;

            if (RendaAnual < 20000)
            {
                valorImposto = RendaAnual * 0.15;
            }
            else
            {
                valorImposto = RendaAnual * 0.25;
            }


            if (DespesaSaude > 0)
            {
                valorImposto = valorImposto - (DespesaSaude * 0.50);
            }

            return valorImposto;
        }

        public override string ToString()
        {
            return Nome + " : R$ " + Imposto().ToString("F2");
        }
    }
}
