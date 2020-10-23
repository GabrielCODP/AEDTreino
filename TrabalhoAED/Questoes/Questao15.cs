using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao15
    {
        static void InverteQueue(Queue Q)
        {
            Stack temp = new Stack(Q);
            Q.Clear();

            foreach (object item in temp)
            {
                Q.Enqueue(item);
            }

            foreach (object item in Q)
            {
                Console.Write($"|{item}|");
            }
        }
        public static void Rodar()
        {
            Queue dados = new Queue();

            for (int i = 0; i < 10; i++)
            {
                dados.Enqueue(i);
            }

            InverteQueue(dados);
        }
    }
}
