using System;
using System.IO;

namespace UtilizandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivoOrigem = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/UtilizandoArquivos/file1.txt";
            string caminhoArquivoDestino = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/UtilizandoArquivos/file2.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoArquivoOrigem);

                // Se arquivo de destino existir exclui ele
                if (File.Exists(caminhoArquivoDestino))
                {
                    File.Delete(caminhoArquivoDestino);
                }

                // Cria file2.rtf
                fileInfo.CopyTo(caminhoArquivoDestino);

                // Faz leitura do arquivo file2.rtf através da string de arrays
                string[] linhas = File.ReadAllLines(caminhoArquivoDestino);
                foreach (string item in linhas)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");

                fileStream = new FileStream(caminhoArquivoOrigem, FileMode.Open);
                streamReader = new StreamReader(fileStream);

            
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro: {0}", ex.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close(); 
            }
        }
    }
}
