using System;

namespace UtilizandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "MEu NoME É Daniel GOLAcker   ";
                
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Substring(3));
            Console.WriteLine(texto.Replace("Daniel", "Maiara"));
        }
    }
}
