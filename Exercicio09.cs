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
    public static class Exercicio09
    {

        public static void Execute(string[] args)
        {
            // Área Midgard
            double areaMidgard = 2827.43;
            // Área Central
            double areaCentral = 314.15;
            // Trecho da área central que corresponde a cada um dos setores
            double areaCentralPorSetor = areaCentral / 8;
            // Área de cada setor considenrando a área central
            double areaSetorComAreaCentral = areaMidgard / 8;
            // Tamanho real da área de cada setor
            double areaSetor = areaSetorComAreaCentral - areaCentralPorSetor;

            Console.WriteLine("Tamanho da área de busca: ");
            Console.WriteLine(areaSetor.ToString() + " km2");
            Console.Read();
        }

    }

}
