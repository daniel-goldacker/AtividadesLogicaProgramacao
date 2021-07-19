using System;
using System.Globalization;

namespace ConcatenacaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double media = 53.234567;


            Console.WriteLine("Concatenação por Placeholder");
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine("");
            Console.WriteLine("Média com oito casas decimais: {0}", media);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", media);
            Console.WriteLine("Separador decimal invariant ciulture: {0}", media.ToString("F3", CultureInfo.InvariantCulture));


            Console.WriteLine("Concatenação por Interpolação");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Média com oito casas decimais: {media}");
            Console.WriteLine($"Arredondado (três casas decimais): {media:F3}");
            Console.WriteLine($"Separador decimal invariant ciulture: {media.ToString("F3", CultureInfo.InvariantCulture)}");


            Console.WriteLine("Concatenação de String");
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero " + genero);
            Console.WriteLine("");
            Console.WriteLine("Média com oito casas decimais: " + media);
            Console.WriteLine("Arredondado (três casas decimais): " + media.ToString("F3"));
            Console.WriteLine("Separador decimal invariant ciulture: " + media.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
