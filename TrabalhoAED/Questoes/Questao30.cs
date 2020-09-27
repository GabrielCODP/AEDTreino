using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao30
    {
        static void InverterStack<T>(Stack<T> S)
        {
            Stack <T> temp = new Stack<T>(S);

            foreach (T item in  S)
            {
                Console.Write($"|{item}|");
            }
            S.Clear();
            Console.WriteLine("\n::::::::::::::::Dados invertidos::::::::::::::::\n");

            foreach (T item in temp)
            {
                S.Push(item);
                Console.Write($"|{item}|");
            }
        }
        public static void Rodar()
        {
            Stack<int> dados = new Stack<int>();

            for (int i = 0; i < 15; i++)
            {
                dados.Push(i + 1);
            }

            InverterStack(dados);

        }
    }
}
