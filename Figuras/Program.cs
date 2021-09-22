using System;
using System.Collections.Generic;
using Figuras.Entidades;
using Figuras.Enumerado;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> listaForma = new List<Forma>();

            Console.Write("Informe a quantidade de formas: ");
            int qtdFormas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFormas; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Firura #{0} dados: ", i);
                Console.Write("Retangulo(r) ou Circulo(c): ");
                string tipoFigura = Console.ReadLine().ToUpper();

                Console.Write("Cor (Preto, Azul ou Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine().ToUpper());

                if (tipoFigura == "R")
                {
                    Console.Write("Informe a altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    Console.Write("Informe a largura: ");
                    double largura = double.Parse(Console.ReadLine());

                    listaForma.Add(new Retangulo(altura, largura, cor));
                } else if (tipoFigura == "C")
                {

                    Console.Write("Informe o Raio: ");
                    double raio = double.Parse(Console.ReadLine());

                    listaForma.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Lista de Áreas: ");
            foreach (var item in listaForma)
            {
                Console.WriteLine(item.Area().ToString("F2"));
            }
        }
    }
}
