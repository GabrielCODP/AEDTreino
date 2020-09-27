using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao29
    {
        static void InverterQueue<T>(Queue<T> Q)
        {
            Stack<T> temp = new Stack<T>(Q);


            foreach (T item in Q)
            {
                Console.Write($"|{item}|");
            }

            Q.Clear();
            Console.WriteLine();
            foreach (T item in temp)
            {
                Q.Enqueue(item);
                Console.Write($"|{item}|");
            }

           

            
           

        }
        public static void Rodar()
        {
            Queue<int> dados = new Queue<int>();

            for (int i = 0; i < 25; i++)
            {
                dados.Enqueue(i);
            }

            InverterQueue(dados);
        }
    }
}
