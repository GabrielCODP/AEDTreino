using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao1
    {
        public static ArrayList CopiaArrayList(ArrayList origem)
        {
            ArrayList dadosCopiados = new ArrayList(origem);

            return dadosCopiados;
        }


        public static void Rodar()
        {
            ArrayList dadosOrigem = new ArrayList { 1, 2, 3, 4, 7, 10, 18 };
            ArrayList dadosRetornado = CopiaArrayList(dadosOrigem);

            foreach (object item in  dadosRetornado)
            {
                Console.WriteLine($"|{item}|");
            }
        }
    }
}
