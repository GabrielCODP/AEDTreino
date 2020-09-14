using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao33
    {
       
        static void DadosPais()//Errado
        {

            Dictionary<string, Dictionary<string, double>> dodos = new Dictionary<string, Dictionary<string, double>>();
            Dictionary<string, double> dadosPaises = new Dictionary<string, double>();

            dadosPaises["Brasil"] = 202656784;
            dadosPaises["México"] = 120286656;
            dadosPaises["EUA"] = 318892096;
            dodos.Add("América", dadosPaises);




            //dadosPaises["Brasil"]= 202656784;
            //dadosPaises["México"] = 120286656;
            //dadosPaises["EUA"] = 318892096;

            



        }
        public static void Rodar()
        {
            DadosPais();

            Console.WriteLine("Continente: ");
            string name = Console.ReadLine();

        }
    }
}
