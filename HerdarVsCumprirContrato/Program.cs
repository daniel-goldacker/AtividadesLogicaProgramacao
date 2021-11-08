using System;
using HerdarVsCumprirContrato.Modelos.Entidades.HERDAR;
using HerdarVsCumprirContrato.Modelos.Entidades.INTERFACE;
using HerdarVsCumprirContrato.Modelos.Enums;

namespace HerdarVsCumprirContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HERDAR: ");
            Figura figura1 = new Modelos.Entidades.HERDAR.Circulo() { Raio = 2.0, Cor = Cor.Preto };
            Figura figura2 = new Modelos.Entidades.HERDAR.Retangulo() { Altura = 4.2, Largura = 3.5, Cor = Cor.Branco };
            Console.WriteLine(figura1);
            Console.WriteLine(figura2);

            Console.WriteLine("");

            Console.WriteLine("INTERFACE: ");
            AFigura figura3 = new Modelos.Entidades.INTERFACE.Circulo() { Raio = 4.0, Cor = Cor.Preto };
            AFigura figura4 = new Modelos.Entidades.INTERFACE.Retangulo() { Altura = 8.2, Largura = 6.5, Cor = Cor.Branco };
            Console.WriteLine(figura3);
            Console.WriteLine(figura4);

        }
    }
}
