using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao8
    {
        static ArrayList Intersecao(ArrayList AL1, ArrayList AL2)
        {
            ArrayList temp = new ArrayList();

            foreach (object item in AL1)
            {
                if (AL2.Contains(item)) 
                {
                    temp.Add(item);
                }
            }

            return temp;

        }
        public static void Rodar()
        {
            ArrayList dados = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            ArrayList dados2 = new ArrayList() { 5, 6, 8, 9, 11, 14, 16 };

            ArrayList dadosEmComum = new ArrayList(Intersecao(dados, dados2));

            foreach (object item in dadosEmComum)
            {
                Console.Write($"|{item}|");
            }

        }
    }
}
