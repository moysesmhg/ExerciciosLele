using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Exercicio05
    {
        public static void Execute(string[] args)
        {
            int totalDinossauros = 1000;
            int qtdYoshiIsland = 450;
            int qtdChocolateIsland = 330;
            int qtdCookieMountain = 340;
            int qtdYoshiIslandEChocolateIsland = 200;
            int qtdYoshiIslandECookieMontain = 180;
            int qtdChocolateIslandECookieMountain = 100;
            int qtdOsTresLocais = 30;

            // Quantidade de Yoshis que gostam de Yoshi Island ou Chocolate Island
            int qtdSomenteYoshiIslandEChocolateIsland = qtdYoshiIslandEChocolateIsland - qtdOsTresLocais;
            // Quantidade de Yoshis que gostam de Yoshi Island ou Cookie Mountains
            int qtdSomenteYoshiIslandECookieMountain = qtdYoshiIslandECookieMontain - qtdOsTresLocais;
            // Quantidade de Yoshis que gostam de Chocolate Island ou Cookie Mountains
            int qtdSomenteChocolateIslandECookieMountain = qtdChocolateIslandECookieMountain - qtdOsTresLocais;

            // Quantidade de Yoshis que gostam apenas de Yoshi Island 
            int qtdSomenteYoshiIsland = qtdYoshiIsland - (qtdSomenteYoshiIslandEChocolateIsland + qtdSomenteYoshiIslandECookieMountain + qtdOsTresLocais);
            // Quantidade de Yoshis que gostam apenas de Chocolate Island
            int qtdSomenteChocolateIsland = qtdChocolateIsland - (qtdSomenteYoshiIslandEChocolateIsland + qtdSomenteChocolateIslandECookieMountain + qtdOsTresLocais);
            // Quantidade de Yoshis que gostam apenas de Cookie Mountains
            int qtdSomenteCookieMountain = qtdCookieMountain - (qtdSomenteYoshiIslandECookieMountain + qtdSomenteChocolateIslandECookieMountain + qtdOsTresLocais);


            int totalApenasUmaIlha = qtdSomenteYoshiIsland + qtdSomenteChocolateIsland + qtdSomenteCookieMountain;
            int totalPeloMenosUmaIlha = qtdYoshiIsland + qtdSomenteCookieMountain + qtdSomenteChocolateIslandECookieMountain + qtdSomenteChocolateIsland;
            int totalNenhumaIlha = totalDinossauros - totalPeloMenosUmaIlha;


            Console.WriteLine("Total De Yoshis Que Gostam De Apenas Uma Ilha: ");
            Console.WriteLine(totalApenasUmaIlha.ToString());
            Console.WriteLine("Total De Yoshis Que Não Gostam de Nenhuma Ilha: ");
            Console.WriteLine(totalNenhumaIlha.ToString());
            Console.Read();
        }


    }

}
