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

                Console.WriteLine("");


                // Usando esta forma não precisa dar closed no FileStream e no StreamReader
                using (FileStream fileStream2 = new FileStream(caminhoArquivoDestino, FileMode.Open))
                {
                    using (StreamReader streamReader2 = new StreamReader(fileStream2))
                    {
                        while (!streamReader2.EndOfStream)
                        {
                            Console.WriteLine(streamReader2.ReadLine());
                        }
                    }
                }

                Console.WriteLine("");

                // Outra forma de ler arquivo sem usar o FileStream usando o File.OpenText
                using (StreamReader streamReader3 = File.OpenText(caminhoArquivoDestino))
                {
                    while (!streamReader3.EndOfStream)
                    {
                        Console.WriteLine(streamReader3.ReadLine());
                    }
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
