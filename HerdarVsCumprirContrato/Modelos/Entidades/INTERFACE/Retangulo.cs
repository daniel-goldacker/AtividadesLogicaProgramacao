using System;
using System.Globalization;

namespace HerdarVsCumprirContrato.Modelos.Entidades.INTERFACE
{
    class Retangulo : AFigura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Objeto = Ratangulo, Cor = " + Cor +
                     ", Largura = " + Largura.ToString("F2", CultureInfo.InvariantCulture) +
                     ", Altura = " + Altura.ToString("F2", CultureInfo.InvariantCulture) +
                     ", Área = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
