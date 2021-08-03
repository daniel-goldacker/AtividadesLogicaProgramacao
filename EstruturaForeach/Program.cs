using System;

namespace EstruturaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaPessoas = new string[] { "daniel", "bruna", "maiara" };

            foreach (var item in listaPessoas)
            {
                Console.WriteLine("Nome: {0}", item);
            }
        }
    }
}
