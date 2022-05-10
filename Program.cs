using System;

namespace calcula_média_de_varios_numeros_de_um_array
{
    class Program
    {
         static void Main(string[] args)
         {
         decimal total = 0;
            decimal entradas = 0;


           while (true)
           {
                Console.WriteLine("digite suas entradas:");
                 decimal numeros = Convert.ToDecimal(Console.ReadLine());


                if (numeros < 0)
                 {
                    break;
                 }
                total = total + numeros;
                entradas++;
            }
            Console.WriteLine($"Amedia dos numeros são: {total / entradas}");
        




        }
    }
}
