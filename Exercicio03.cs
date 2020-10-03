using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Exercicio03
    {
        public static void Execute(string[] args)
        {
            double velocidadeConstante = 80;
            // O valor do ângulo de 45 graus é: Raiz de 2 divido por 2
            double angulo = Math.Cos(Math.PI / 4);
            // Faz a correção da velocidade considerando o ângulo
            double velocidadeMS = (velocidadeConstante / 3.6) * angulo;
            double distanciaInicial = 0;
            // tempo em segundos
            double tempoEmSegundos = 5;
            // distância total no sentido horizontal (desconsiderando a inclinação do ângulo)
            double distanciaTotal = distanciaInicial + (velocidadeMS * tempoEmSegundos);

            Console.WriteLine("Distância Total Percorrida: ");
            Console.WriteLine(distanciaTotal.ToString() + " metros");
            Console.Read();
        }

    }

}
