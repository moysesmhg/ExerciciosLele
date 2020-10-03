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
    public static class Exercicio06
    {
        public static void Execute(string[] args)
        {
            // Apenas letras que correspondem a valores hexadecimais
            string letrasPossiveis = "ABCDEF";
            // A senha não possui o número 0, e não possui os números 7 e 8 pela impossibilidade
            // da soma dos dígitos ser 8
            string numerosPossiveis = "123456";

            // Lista de combinações possíveis de letras
            List<string> listaLetras = ObterCombinacao(letrasPossiveis);
            // Lista de combinações possíveis de números
            List<string> listaNumeros = ObterCombinacao(numerosPossiveis);
            List<string> listaSenhasTemp = new List<string>();

            // Armazena em uma lista temporária todas as combinações possíveis de senha,
            // obedecendo o formato LLLDDD, sem fazer as validações necessárias
            foreach (string combLetra in listaLetras)
            {
                foreach (string combNumero in listaNumeros)
                {
                    listaSenhasTemp.Add(combLetra + combNumero);
                }
            }

            // Verifia se cada senha possível é potencialmente válida, considerando
            // as restrições impostas na questão
            List<string> senhasValidas = new List<string>();
            foreach (string senha in listaSenhasTemp)
            {
                if (ValidarSenha(senha))
                {
                    senhasValidas.Add(senha);
                }
            }

            // 2 segundos para cada tentativa
            int tempoTentativa = 2;
            // quantidade de senhas válidas
            int qtdSenhasValidas = senhasValidas.Count;
            // tempo total em segundos
            int tempoTotalSegundos = qtdSenhasValidas * tempoTentativa;
            // tempo total em minutos
            double tempoTotalMinutos = tempoTotalSegundos / 60;

            // Prepara todas as senhas válidas para impressão
            string separador = "";
            string listaFinal = "";
            foreach (string numero in senhasValidas)
            {
                listaFinal += separador + numero.ToString();
                separador = ", ";
            }

            Console.WriteLine("Tempo total para testar todas as senhas válidas: ");
            Console.WriteLine(tempoTotalSegundos.ToString() + " segundos (" + tempoTotalMinutos.ToString() + " minuitos) ");
            Console.WriteLine();
            Console.WriteLine("Todas as senhas possíveis: ");
            Console.WriteLine(listaFinal);
            Console.Read();

        }

        public static List<string> ObterCombinacao(string sequencia)
        {
            List<string> query = (from a in sequencia
                                  from b in sequencia
                                  from c in sequencia
                                  select "" + a + b + c).ToList();

            return query;
        }

        public static bool ValidarSenha(string senha)
        {
            string alfabeto = "ABCDEF";

            // Verifica se há letras repetidas
            foreach (char letra in alfabeto)
            {
                if (senha.Count(a => a == letra) > 1)
                {
                    return false;
                }
            }

            // Verifica se as letras A e D estão presentes na senha
            if (senha.Count(a => a == 'A') == 0 || senha.Count(a => a == 'D') == 0)
            {
                return false;
            }

            // Verifica se os dígitos 3 ou 6 são os primeiros da sequência de dígitos
            if (senha[3] != '3' && senha[3] != '6')
            {
                return false;
            }

            // Verifica se a soma dos dígitos é 8
            string digitos = Regex.Replace(senha, "[^0-9]", "");

            int somaDigitos = 0;
            foreach (char digito in digitos)
            {
                somaDigitos += Convert.ToInt32(digito.ToString());
            }
            if (somaDigitos != 8)
            {
                return false;
            }

            // Verifica se há dígitos 0
            if (senha.Where(a => a == '0').Count() > 0)
            {
                return false;
            }

            return true;
        }

    }

}
