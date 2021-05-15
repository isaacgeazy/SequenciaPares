using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
             int contador = 0, n;

                Console.Write("Números pares entre 0 e ? "); 
                n = int.Parse(Console.ReadLine());

            while (contador <= n){

             Console.Write($"{ contador } ");
              contador = contador + 2;
            }
        }
    }
}
