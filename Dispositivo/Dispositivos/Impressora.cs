using System;
namespace Dispositivo.Dispositivos
{
    class Impressora: Dispositivo, IImpressora
    {
       
        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("Processamento da impressora: {0}", documento);
        }
        
        public void Imprimir(string documento)
        {
            Console.WriteLine("Impressão da impressora: {0}", documento);
        }
    }
}
