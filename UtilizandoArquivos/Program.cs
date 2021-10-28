using System;
using System.Collections.Generic;
using System.IO;

namespace UtilizandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivoOrigem = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/UtilizandoArquivos/file1.txt";
            string caminhoArquivoDestino = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/UtilizandoArquivos/file2.txt";
            string caminhoPasta = @"/Users/danielgoldacker/Desktop/AtividadesLogicaProgramacao/UtilizandoArquivos/minhaPasta";
            
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoArquivoOrigem);

                ExcluirArquivo(caminhoArquivoDestino);
             
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

                Console.WriteLine("");


                ExcluirArquivo(caminhoArquivoDestino);


                // Escreve em arquivo 
                string[] lines = File.ReadAllLines(caminhoArquivoOrigem);
                using (StreamWriter streamWriter = File.AppendText(caminhoArquivoDestino))
                {
                    foreach (string item in lines)
                    {
                        streamWriter.WriteLine(item.ToUpper());
                    }
                }


                Console.WriteLine("");


                // Listar subpastas de uma pasta
                IEnumerable<string> pasta = Directory.EnumerateDirectories(caminhoPasta, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pasta: ");

                foreach (string item in pasta)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");

                // Listar arquivos de uma pasta e suas subpastas
                IEnumerable<string> arquivos = Directory.EnumerateFiles(caminhoPasta, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos: ");

                foreach (string item in arquivos)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("");

                // Cria uma pasta
                ExcluirPasta(caminhoPasta + "/novaPasta");
                Directory.CreateDirectory(caminhoPasta + "/novaPasta");

                Console.WriteLine("");


                // Utilizando GetTempPath
                Console.WriteLine("GetDirectoryName: {0}", Path.GetDirectoryName(caminhoArquivoDestino));
                Console.WriteLine("DirectorySeparatorChar: {0}", Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: {0}", Path.PathSeparator);
                Console.WriteLine("GetFileName: {0}", Path.GetFileName(caminhoArquivoDestino));
                Console.WriteLine("GetFileNameWithoutExtension: {0}", Path.GetFileNameWithoutExtension(caminhoArquivoDestino));
                Console.WriteLine("GetExtension: {0}", Path.GetExtension(caminhoArquivoDestino));
                Console.WriteLine("GetFullPath: {0}", Path.GetFullPath(caminhoArquivoDestino));
                Console.WriteLine("GetTempPath: {0}", Path.GetTempPath());
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

        static void ExcluirArquivo(String caminhoArquivo)
        {
            // Se arquivo de destino existir exclui
            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
            }
        }

        static void ExcluirPasta(string caminhoPasta)
        {
            // Se pasta existir exclui
            if (Directory.Exists(caminhoPasta))
            {
                Directory.Delete(caminhoPasta, true);
            }
        }
    }
}
