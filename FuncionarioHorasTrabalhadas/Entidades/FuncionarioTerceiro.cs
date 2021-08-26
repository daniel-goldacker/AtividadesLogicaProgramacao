using System;
using System.Text;

namespace FuncionarioHorasTrabalhadas.Entidades
{
    public class FuncionarioTerceiro : Funcionario
    {
        public double ValorAdicional { get; set; }
        private const double bonus = 110;


        public FuncionarioTerceiro()
        {
        }

        public FuncionarioTerceiro(string nome, int horas, double valorHoras, double valorAdicional) : base(nome, horas, valorHoras)
        {
            ValorAdicional = valorAdicional;
        }

        public sealed override double Pagamento()
        {   
            return base.Pagamento() + (ValorAdicional * (bonus / 100));
        }
    }
}
