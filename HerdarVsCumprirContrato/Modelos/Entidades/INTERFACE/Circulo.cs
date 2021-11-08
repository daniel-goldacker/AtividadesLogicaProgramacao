using System;
using System.Globalization;

namespace HerdarVsCumprirContrato.Modelos.Entidades.INTERFACE
{
    class Circulo : AFigura
    { 
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Objeto = Circulo, Cor = " + Cor +
                   ", Raio = " + Raio.ToString("F2", CultureInfo.InvariantCulture) +
                   ", Área = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
