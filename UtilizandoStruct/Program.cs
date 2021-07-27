using System;

namespace UtilizandoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizando struct não precisa intanciar;
            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            // Paga gerar um novo objeto basta dar um new
            p = new Point();
            Console.WriteLine(p);


        }
    }
}
