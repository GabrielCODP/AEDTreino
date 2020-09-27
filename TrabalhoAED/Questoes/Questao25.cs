using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao25
    {
        static void ApagaQueue(Queue<int> origem, int inicio, int final)
        {
            int queueTamanho = origem.Count;

            Console.WriteLine("\nOrigem");

            foreach (object item in origem)
            {

                Console.Write($"|{item}|");
            }

            for (int i = 0; i < queueTamanho; i++)
            {
                if (i >= inicio && i <= final)
                    origem.Dequeue();
                else
                    origem.Enqueue(origem.Dequeue());
            }

            Console.WriteLine("\nRemovido");

            foreach (object item in origem)
            {

                Console.Write($"|{item}|");
            }
        }
        public static void Rodar()
        {
            Queue<int> dados = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                dados.Enqueue(i + 1);
            }

            ApagaQueue(dados, 5, 7);
        }
    }
}
