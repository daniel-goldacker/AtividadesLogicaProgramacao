using System;

namespace UtilizandoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizando struct não precisa instanciar;
            Point p1;

            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine(p1);

            /* Ao fazer isso no struct ele atribui o valor de p1 em uma nova variável chamada p2 não fazendo referência a um ponteiro de 
             * memória como em uma classe */
            Point p2 = p1; 
            p2.X = 99;

            Console.WriteLine(p2);
            Console.WriteLine(p1);


            // Para gerar um novo objeto(struct) basta dar um new assim como em uma classe.
            p1 = new Point();
            Console.WriteLine(p1);
           
        }
    }
}
