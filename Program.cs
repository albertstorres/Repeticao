using System;

namespace Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAÇO DE REPETIÇÃO FOR
            for (int i = 0; i <= 5; i++)
                Console.WriteLine(i);

            Console.WriteLine("_________________");

            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);

            Console.WriteLine("_________________");

            for (int i = 0; i <= 4; i++)
                Console.WriteLine(i);

            Console.WriteLine("_________________");

            for (int i = 5; i >= 0; i--)
                Console.WriteLine(i);

            Console.WriteLine("_________________");
            //FIM LAÇO DE REPETIÇÃO FOR.

            //LAÇO DE REPETIÇÃO WHILE
            int valor = 0;

            while (valor <= 5)
            {
                Console.WriteLine(valor);
                valor++;
            }
            //FIM LAÇO DE REPETIÇÃO WHILE.

            //LAÇO DE REPETIÇÃO DO WHILE.
            int contador = 0;

            do
            {
                Console.WriteLine("Teste");
                contador++;
            } while (contador < 5);
            //FIM LAÇO DE REPETIÇÃO DO WHILE.
        }
    }
}
