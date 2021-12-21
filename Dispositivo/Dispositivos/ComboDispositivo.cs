using System;
namespace Dispositivo.Dispositivos
{
    class ComboDispositivo : Dispositivo, IImpressora, IScanner
    {
       
        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("Impressão do combodispositivo: {0}", documento);
        }

        public void Imprimir(string documento)
        {
            Console.WriteLine("Processamento do combodispositivo: {0}", documento);
        }

        public string Scan()
        {
            return "Resultado da varredura do combodispositivo";
        }
    }
}
