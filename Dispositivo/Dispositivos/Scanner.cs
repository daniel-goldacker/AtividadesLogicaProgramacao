using System;
namespace Dispositivo.Dispositivos
{
    class Scanner: Dispositivo, IScanner
    {

        public override void ProcessaDoc(string documento)
        {
            Console.WriteLine("Processamento do scanner: {0}", documento);
        }

            public string Scan()
        {
            return "Resultado da varredura do scanner";
        }
    }
}
