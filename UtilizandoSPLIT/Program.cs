using System;

namespace UtilizandoSPLIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome completo:");
            string[] nome = Console.ReadLine().Split(' ');

            Console.WriteLine("Nome quebrado por espaço: ");
            foreach (var item in nome)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
