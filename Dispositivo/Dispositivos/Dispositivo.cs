using System;
namespace Dispositivo.Dispositivos
{
    abstract class Dispositivo
    {
        public int NumeroSerial { get; set; }

        public abstract void ProcessaDoc(string documento);
    }
}
