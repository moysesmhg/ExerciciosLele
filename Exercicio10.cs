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
    public static class Exercicio10
    {
        public static int Linha;

        public static void Execute(string[] args)
        {
            // número inicial
            int numero = 1;
            // linha inicial
            Linha = 1;
            Processar(numero);

            Console.WriteLine("Linha (código da porta): ");
            Console.WriteLine(Linha.ToString());
            Console.Read();
        }

        public static void Processar(int numero)
        {
            // O processo continua até achar o número do ano ds fundação da delegacia (1969)
            if (numero != 1969)
            {
                // Os números só passam a ser escritos na próxima linha, caso
                // a raiz quadrada do número atual for igual ao valor da linha atual
                if (Math.Sqrt(numero) == Linha)
                {
                    Linha++;
                }
                // Incrementa o número
                numero++;
                // Utiliza a recursividade
                Processar(numero);
            }

        }

    }

}
