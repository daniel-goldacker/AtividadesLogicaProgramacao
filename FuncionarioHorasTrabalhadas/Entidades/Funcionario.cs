using System;
using System.Text;

namespace FuncionarioHorasTrabalhadas.Entidades
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHoras { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorHoras = valorHoras;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHoras;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome);
            sb.Append(" - R$ ");
            sb.AppendLine(Pagamento().ToString());
            return sb.ToString();
        }

    }
}
