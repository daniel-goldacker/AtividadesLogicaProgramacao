using System;
using System.IO;

namespace ItensVendidosArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivoVendasEntrada = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/ItensVendidosArquivo/vendas.csv";
            string caminhoArquivoVendasSaida = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/ItensVendidosArquivo/saida/resumo.csv";

            try
            {
                // Se o arquivo caminhoArquivoVendasSaida existir exclui
                if (File.Exists(caminhoArquivoVendasSaida))
                {
                    File.Delete(caminhoArquivoVendasSaida);
                }

                // Mostra entrada
                using (StreamReader streamReader = File.OpenText(caminhoArquivoVendasEntrada))
                {
                    while (!streamReader.EndOfStream)
                    {
                        Console.WriteLine(streamReader.ReadLine().Replace(",", " - "));
                    }
                }

                Console.WriteLine("");

                using (StreamReader streamReader = File.OpenText(caminhoArquivoVendasEntrada))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] arquivos = streamReader.ReadLine().Split(',');

                        using (StreamWriter streamWriter = File.AppendText(caminhoArquivoVendasSaida))
                        {
                            streamWriter.WriteLine(arquivos[0] + "," + Double.Parse(arquivos[1]) * Double.Parse(arquivos[2]));
                        }
                    }
                }

                Console.WriteLine("");

                // Mostra saída processada
                using (StreamReader streamReader = File.OpenText(caminhoArquivoVendasSaida))
                {
                    while (!streamReader.EndOfStream)
                    {
                        Console.WriteLine(streamReader.ReadLine().Replace(",", " - "));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro: {0}", ex.Message);
            }
          
        }
    }
}
