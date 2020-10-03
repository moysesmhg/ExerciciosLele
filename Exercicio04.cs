using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Exercicio04
    {
        public static int TotalVariacoes = 0;
        public static int VariacoesPassarFase = 0;

        public static void Execute(string[] args)
        {
            List<string> area2 = new List<string> { "A", "B", "C" };

            // Área 1 não tem variação
            // Área 2
            foreach (string area in area2)
            {
                // Variação A
                if (area == "A")
                {
                    TotalVariacoes++;
                    Area3();
                }
                // Variação B
                else if (area == "B")
                {
                    TotalVariacoes++;
                    Area3();
                }
                // Variação C
                else
                {
                    TotalVariacoes++;
                    Area3();
                }
            }

            Console.WriteLine("Total De Variações: ");
            Console.WriteLine(TotalVariacoes.ToString());
            Console.WriteLine("Total De Variações nas quais é possível passar a fase: ");
            Console.WriteLine(VariacoesPassarFase.ToString());
            Console.Read();
        }

        public static void Area3()
        {
            List<string> area3 = new List<string> { "A", "B", "C" };

            foreach (string area in area3)
            {
                // Variação B
                if (area == "B")
                {
                    TotalVariacoes++;
                    Area4();
                }
                // Variação C
                else if (area == "C")
                {
                    TotalVariacoes++;
                    Area4();
                }
                // Variação A
                else
                {
                    TotalVariacoes++;
                    VariacoesPassarFase++;
                }
            }
        }

        public static void Area4()
        {
            List<string> area4 = new List<string> { "A", "B"};

            foreach (string area in area4)
            {
                // Variação A
                if (area == "A")
                {
                    TotalVariacoes++;
                    VariacoesPassarFase++;
                }
                // Variação B
                else
                {
                    TotalVariacoes++;
                    VariacoesPassarFase++;
                }
            }
        }

    }

}
