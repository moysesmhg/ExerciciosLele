using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Exercicio02
    {
        public static void Execute(string[] args)
        {
            // Adiciona na lista os números de 2 a 120
            int[] listaTab = new int[120];
            for (int i = 2; i <= 120; i++)
            {
                listaTab[i - 2] = i;
            }

            int indexNaoPrimos = 0;
            int[] naoPrimos = new int[120];
            foreach (int numero in listaTab)
            {
                // Caso o número já esteja no array de não-primos, não é necessária a verificação
                // de que ele é primo
                if (!naoPrimos.Contains(numero))
                {
                    // Verifica se é primo
                    bool ehPrimo = VerificaNumeroPrimo(numero);

                    // Se o número for primo verifica os seus múltiplos cujo valor seja menor que
                    // 120 e adiciona no array de não-primos
                    if (ehPrimo)
                    {
                        for (int i = numero; i <= 120; i++)
                        {
                            int multiplo = numero * i;

                            if (multiplo <= 120 && !naoPrimos.Contains(multiplo))
                            {
                                naoPrimos[indexNaoPrimos] = multiplo;
                                indexNaoPrimos++;
                            }

                        }
                    }
                }

            }
            // Reduz o tamanho do array ao agrupar os números repitidos
            naoPrimos = naoPrimos.Distinct().ToArray();
            // Função do linq que elimina da lista principal todos os não-primos
            listaTab = listaTab.Except(naoPrimos).ToArray();           
           
            // Armazena na string todos os números primos separados por vírgula
            string separador = "";
            string listaFinal = "";
            foreach (int numero in listaTab)
            {
                listaFinal += separador + numero.ToString();
                separador = ", ";
            }

            Console.WriteLine("Lista de números primos: ");
            Console.WriteLine(listaFinal);
            Console.Read();
        }

        public static bool VerificaNumeroPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }


    }

}
