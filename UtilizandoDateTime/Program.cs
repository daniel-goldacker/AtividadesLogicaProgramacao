using System;

namespace UtilizandoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = DateTime.Now;
            DateTime data2 = DateTime.Today;
            DateTime data3 = new DateTime(1993,5,1);

            Console.WriteLine(data1); // Data Atual
            Console.WriteLine(data2); // Data Atual com Hora Zerada
            Console.WriteLine(data3);

            // Adicionar dias a uma data
            DateTime data4 = data3.AddDays(5); 

            Console.WriteLine(data4);

            // Subtrair data
            TimeSpan t = data4.Subtract(data3);
            Console.WriteLine(t);

            DateTime date5 = new DateTime(2000, 5, 22, 17, 32, 23, DateTimeKind.Local);
            Console.WriteLine(date5);

            DateTime date6 = new DateTime(2000, 5, 22, 17, 32, 23, DateTimeKind.Utc);
            Console.WriteLine(date6);

            DateTime date7 = new DateTime(2000, 5, 22, 17, 32, 23);
            Console.WriteLine(date7);
        }
    }
}
