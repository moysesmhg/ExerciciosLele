using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEncodingConverter;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int numeroExercicio = 3;

            switch (numeroExercicio)
            {
                case 1:
                    break;
                case 2:
                    Exercicio02.Execute(args);
                    break;
                case 3:
                    Exercicio03.Execute(args);
                    break;
                case 4:
                    Exercicio04.Execute(args);
                    break;
                case 5:
                    Exercicio05.Execute(args);
                    break;
                case 6:
                    Exercicio06.Execute(args);
                    break;
                case 8:
                    Exercicio08.Execute(args);
                    break;
                case 9:
                    Exercicio09.Execute(args);
                    break;
                case 10:
                    Exercicio10.Execute(args);
                    break;
                default:
                    break;
            }
        }




    }

}
