using System;
namespace UtilizandoHeranca.Entidades
{
    public class ContaNegocio : Conta
    {

        public double LimiteEmprestimo { get; set; }

        public ContaNegocio()
        {
        }

        //  base(numero, titular, saldo) - Chama o construtor da superclasse (Conta)
        public ContaNegocio(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
