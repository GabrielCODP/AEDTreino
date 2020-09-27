using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao4
    {
        static void ApagaArrayList(ArrayList origem, int inicio, int final)
        {

            for (int i = inicio; i <= final; i++)
            {
                origem.RemoveAt(inicio);
            }

            foreach (object item in origem)
            {
                Console.WriteLine(item);
            }
  
        }
        public static void Rodar()
        {
            ArrayList dados = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            ApagaArrayList(dados, 7, 10);



        }
    }
}
