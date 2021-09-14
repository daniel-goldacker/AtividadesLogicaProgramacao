using System;
namespace UtilizandoHeranca.Entidades
{
    abstract class ContaPrincipal
    {

        private int Numero { get; set; }
        private string Titular { get; set; }

        public ContaPrincipal()
        {
        }

        public ContaPrincipal(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
    }
}
