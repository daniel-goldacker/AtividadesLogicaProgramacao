using System;
using Figuras.Enumerado;

namespace Figuras.Entidades
{
    class Retangulo : Forma
    {

        public double Altua { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altua, double largura, Cor cor) : base(cor)
        {
            Altua = altua;
            Largura = largura;
        }

        public override double Area()
        {
            return Altua * Largura;
        }
    }
}
