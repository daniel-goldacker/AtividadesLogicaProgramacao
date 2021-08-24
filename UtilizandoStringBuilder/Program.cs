using System;
using System.Globalization;
using UtilizandoStringBuilder.Entidades;

namespace UtilizandoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            // Publicação 1 
            Comentario comentario1 = new Comentario("Tenha uma boa viagem");
            Comentario comentario2 = new Comentario("uau isso é incrível");

            Publicar publicar1 = new Publicar(
                DateTime.Parse("21/06/2018 13:05:44", new CultureInfo("pt-BR")),
                "Viajando para nova zelândia",
                "Vou visitar este país maravilhoso",
                12);

            publicar1.AdicionarComentario(comentario1);
            publicar1.AdicionarComentario(comentario2);


            // Publicação 2 
            Comentario comentario3 = new Comentario("Boa noite");
            Comentario comentario4 = new Comentario("Que a força esteja com você");

            Publicar publicar2 = new Publicar(
                DateTime.Parse("28/07/2018 23:14:19", new CultureInfo("pt-BR")),
                "Boa noite galera",
                "Vejo vocês amanhã",
                5);

            publicar2.AdicionarComentario(comentario3);
            publicar2.AdicionarComentario(comentario4);

            Console.WriteLine(publicar1);
            Console.WriteLine("");
            Console.WriteLine(publicar2);
        }
    }
}
