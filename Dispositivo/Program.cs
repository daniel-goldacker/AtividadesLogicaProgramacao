using System;
using Dispositivo.Dispositivos;

namespace Dispositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressora p = new Impressora() { NumeroSerial = 1080};
            p.ProcessaDoc("Minha Carta");
            p.Imprimir("Minha Carta");

            Scanner s = new Scanner() { NumeroSerial = 2003 };
            s.ProcessaDoc("Meu E-mail");
            Console.WriteLine(s.Scan());

            ComboDispositivo cd = new ComboDispositivo() { NumeroSerial = 2250 };
            cd.ProcessaDoc("Minha disertação");
            cd.Imprimir("Minha disertação");
            Console.WriteLine(cd.Scan());

        }
    }
}
