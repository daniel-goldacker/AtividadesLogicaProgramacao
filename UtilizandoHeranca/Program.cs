using System;
using UtilizandoHeranca.Entidades;

namespace UtilizandoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Superclasse = Classe pai
            // Subclasse = Classse filho 
            Conta conta = new Conta(8010, "Daniel", 150);
            ContaNegocio contaNegocio = new ContaNegocio(8011, "Bruna", 150, 1000);


            // UPCASTING
            Conta conta1 = contaNegocio;
            Conta conta2 = new ContaNegocio(8012, "Maiara", 560, 1500);
            Conta conta3 = new ContaPoupanca(8013, "Pedro", 560, 0.02);

            //DOWNCASTING (Operação não segura)
            ContaNegocio contaNegocio1 = (ContaNegocio)conta2;

            if (conta3 is ContaNegocio)
            {
                ContaNegocio contaNegocio2 = (ContaNegocio)conta3;
            }

        }
    }
}
