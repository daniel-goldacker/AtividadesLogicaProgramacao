using System;

namespace UtilizandoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 2];

            Console.WriteLine(matriz.Length); // tamanho dsa matriz
            Console.WriteLine(matriz.Rank); // quantidade de linhas
        }
    }
}
