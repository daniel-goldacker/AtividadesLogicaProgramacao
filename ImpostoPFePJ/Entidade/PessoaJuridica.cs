using System;
namespace ImpostoPFePJ.Entidade
{
    class PessoaJuridica : Pessoa
    {

        public int QtdeEmpregados { get; set; }


        public PessoaJuridica(int qtdeEmpregados, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            QtdeEmpregados = qtdeEmpregados;
        }

        public override double Imposto()
        {
            double valorImposto = 0;

            if (QtdeEmpregados <= 10)
            {
                valorImposto = RendaAnual * 0.16;
            }
            else
            {
                valorImposto = RendaAnual * 0.14;
            }

            return valorImposto;
        }

        public override string ToString()
        {
            return Nome + " : R$ " + Imposto().ToString("F2");
        }
    }
}
