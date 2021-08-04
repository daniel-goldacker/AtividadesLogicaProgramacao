using System;

namespace NumerosProximosMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a qualtidade de linhas: ");
            int qtdLinha = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de colunas: ");
            int qtdColuna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[qtdLinha, qtdColuna];

            for (int linha = 0; linha < qtdLinha; linha++)
            {
                string[] linhaDigitada = Console.ReadLine().Split(' ');
                for (int coluna = 0; coluna < qtdColuna; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(linhaDigitada[coluna]);   
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Digite um número para procurar: ");
            int numeroProcurar = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < qtdLinha; linha++)
            {
                for (int coluna = 0; coluna < qtdColuna; coluna++)
                {
                    if (matriz[linha, coluna] == numeroProcurar)
                    {
                        imprimeValores(matriz, qtdLinha, qtdColuna, linha, coluna);
                    }
                } 
            }
        }

        static void imprimeValores(int[,] matriz, int qtdLinha, int qtdColuna, int linha, int coluna)
        {
            Console.WriteLine("Posição [{0}, {1}]: ", linha, coluna);

            // Pega o valor da matriz de cada número próximo
            int esquerda = coluna - 1;
            int direita = coluna + 1;
            int cima = linha - 1;
            int baixo = linha + 1;

            // Pega a qtde máxima do vetorh para linhas e colunas
            int qtdMaxColuna = qtdColuna - 1; // diminui 1 pois começa do zero
            int qtdMaxLinhas = qtdLinha - 1;  // diminui 1 pois começa do zero

            if (esquerda >= 0)
            {
                Console.WriteLine(" * Na Esquerda: {0}", matriz[linha, esquerda]);
            }

            if (direita <= qtdMaxColuna)
            {
                Console.WriteLine(" * Na Direita: {0}", matriz[linha, direita]);
            }

            if (cima >= 0)
            {
                Console.WriteLine(" * Em Cima: {0}", matriz[cima, coluna]);
            }

            if (baixo <= qtdMaxLinhas)
            {
                Console.WriteLine(" * Em Baixo: {0}", matriz[baixo, coluna]);
            }

            Console.WriteLine("");
        }
    }
}
