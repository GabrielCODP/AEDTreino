using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao16
    {
        static void InverterStack(Stack S)
        {
            Queue temp = new Queue(S);
            S.Clear();
            foreach (object item in temp)
            {
                S.Push(item);
            }
            foreach (object item in S)
            {
                Console.Write($"|{item}|");
            }

        }
        public static void Rodar()
        {
            Stack dados = new Stack();

            for (int i = 0; i < 10; i++) 
            {
                dados.Push(i);
            }

            InverterStack(dados);
        }
    }
}
