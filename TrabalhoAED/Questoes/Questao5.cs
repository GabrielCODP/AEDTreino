using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao5
    {
        static void ApagarArrayList2(ArrayList origem, int inicio, int qtde)
        {

            for (int i = inicio; i <= qtde ; i++)
            {
                origem.RemoveAt(inicio);
            }

            foreach (int item in origem)
            {
                Console.WriteLine(item);
            }

        }

        public static void Rodar()
        {
            ArrayList dados = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            Console.Write("Apagar a partir de qual posição do parâmetro: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Quantidade a apagar:");
            int qtde = int.Parse(Console.ReadLine());

            ApagarArrayList2(dados, inicio, qtde);
        }
    }
}
