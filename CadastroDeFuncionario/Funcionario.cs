using System;
namespace CadastroDeFuncionario
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            AlterarSalario(salario);
           
        }
        public static double CalculaAumentoSalario(double percentual, double salario)
        {
            return salario + (salario * (percentual / 100));
        }

        public void AlterarSalario(double salario)
        {
            Salario = salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");
        }

       
    }
}
