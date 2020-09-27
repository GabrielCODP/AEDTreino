using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    //Recebi conselhos do Bruno nessa questão.
    public static class Questao33
    {
        static void DadosPais()//Errado
        {
            SortedList dadosPaises = new SortedList();
            SortedList dadosContinente = new SortedList();
            double cont = 0;


            dadosPaises["Brasil"] = 202656784;
            dadosPaises["México"] = 120286656;
            dadosPaises["Estados Unidos"] = 318892096;
            dadosPaises["Colômbia"] = 48168996;
            dadosPaises["Argentina"] = 44694200;
            dadosPaises["Cuba"] = 11116396;
            dadosContinente.Add("América", dadosPaises);

            dadosPaises = new SortedList();

            dadosPaises["Japão"] = 127103392;
            dadosPaises["Índia"] = 1296834048;
            dadosPaises["China"] = 1384689024;
            dadosPaises["Coreia do Norte"] = 25381084;
            dadosPaises["Coreia do Sul"] = 51418096;
            dadosPaises["Tailândia"] = 68615856;
            dadosContinente.Add("Ásia", dadosPaises);

            dadosPaises = new SortedList();

            dadosPaises["França"] = 67364360;
            dadosPaises["Suíça"] = 8292809;
            dadosPaises["Suécia"] = 10040995;
            dadosPaises["Alemanha"] = 80457736;
            dadosPaises["Ucrânia"] = 43952300;
            dadosPaises["Noruega"] = 5372191;
            dadosContinente.Add("Europa", dadosPaises);





            foreach (DictionaryEntry item in (SortedList)dadosContinente)
            {
               
                Console.WriteLine($"Continente: {item.Key}");

                foreach (DictionaryEntry item2 in (SortedList)item.Value)
                {
                    Console.WriteLine($"\nPais: {item2.Key}|| População:{item2.Value}");
                    cont += (int)item2.Value;
                }

                Console.WriteLine($"\nPopulação total: {cont.ToString(CultureInfo.InvariantCulture)}");
                cont = 0;
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::");
            }


        }
        public static void Rodar()
        {
            DadosPais();

            

        }
    }
}
