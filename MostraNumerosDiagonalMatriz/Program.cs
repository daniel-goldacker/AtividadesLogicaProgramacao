using System;

namespace MostraNumerosDiagonalMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a ordem da matriz: ");
            int ordemMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[ordemMatriz, ordemMatriz];

            for (int linha = 0; linha < ordemMatriz; linha++)
            {
                string[] valorLinha = Console.ReadLine().Split(' ');
            
                for (int coluna = 0; coluna < ordemMatriz; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(valorLinha[coluna]);
                }
            }

            string diagonal = "";
            int numerosNegativos = 0;

            for (int linha = 0; linha < ordemMatriz; linha++)
            { 
                for (int coluna = 0; coluna  < ordemMatriz; coluna ++)
                {
                    if (linha == coluna)
                    {
                        diagonal += matriz[linha, coluna] + " ";
                    }

                    if (matriz[linha, coluna] < 0)
                    {
                        numerosNegativos++;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Diagonal: {0} ", diagonal);
            Console.WriteLine("Negativos: {0}", numerosNegativos);
        }
    }
}
