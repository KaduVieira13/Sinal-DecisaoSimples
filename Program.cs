using System;

namespace Sinal_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sinais ---\n");

            Console.Write("Digite o numero desejado: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado <0 )
            {
                Console.WriteLine($"O {numeroDigitado} é negativo.");
            }
            else if (numeroDigitado == 0)
            {
                Console.WriteLine($"O numero {numeroDigitado} é zero.");
            }
            else
            {
              Console.WriteLine($"O numero {numeroDigitado} é positivo.");
            }

            Console.WriteLine("Obrigado por utilizar nosso programa!");
        }
    }
}
