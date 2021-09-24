using System;
using System.Globalization;
using ReservaQuarto.Entidade.Excecao;

namespace ReservaQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());

                Console.Write("Data de entrada: ");
                DateTime dataEntrada = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                Console.Write("Data de saída: ");
                DateTime dataSaida = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                Reserva reserva = new Reserva(numQuarto, dataEntrada, dataSaida);
                Console.WriteLine("Reserva: {0}", reserva.ToString());

                Console.WriteLine("");
                Console.WriteLine("Informe os dados para atualizar a reserva: ");

                Console.Write("Data de entrada: ");
                dataEntrada = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                Console.Write("Data de saída: ");
                dataSaida = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                reserva.AtualizaDatas(dataEntrada, dataSaida);
                Console.WriteLine("Reserva: {0}", reserva.ToString());
            } catch (DominioExcecao e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }catch(FormatException e)
            {
                Console.WriteLine("Formato Inválido");
            }
            catch(Exception e)
            {
                Console.WriteLine("ERRO: {0}", e.Message);
            }
        }
    }
}
