using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Exercicio08
    {
        public static int NumeroDeMovimentos;

        public static void Execute(string[] args)
        {
            int quantidadeDeDiscos = 5; // Quantidade de Discos
            char pinoA = 'A'; // Pino Inicial
            char pinoB = 'B'; // Pino Central (que terá função de temporário)
            char pinoC = 'C'; // Pino Final

            RealizarMovimentos(quantidadeDeDiscos, pinoA, pinoC, pinoB);

            Console.WriteLine("Número De Movimentos: ");
            Console.WriteLine(NumeroDeMovimentos.ToString());
            Console.Read();
        }

        private static void RealizarMovimentos(int disco, char pinoInicial, char pinoFinal, char pinoCentral)
        {
            // Como está sendo utilizada a recursividade, esta validação é necessária,
            // pois a "pilha" montada só pode ter os discos de 1 a 5
            if (disco > 0)
            {
                NumeroDeMovimentos++;
                RealizarMovimentos(disco - 1, pinoInicial, pinoCentral, pinoFinal);                
                RealizarMovimentos(disco - 1, pinoCentral, pinoFinal, pinoInicial);
            }

        }

    }

}
