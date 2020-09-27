using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao27
    {
        static Stack<T> CopiaStack<T>(Stack<T> origem)
        {
            List<T> DadosReverse = new List<T>(origem);
            Stack<T> newDados = new Stack<T>();

            DadosReverse.Reverse();

            foreach (var item in DadosReverse)
            {
                newDados.Push(item);
            }


            return newDados;//A ordem original vai ser igual.

        }
        public static void Rodar()
        {
            Stack<int> dados = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                dados.Push(i);
            }

            Stack<int>dadosCopiados = CopiaStack(dados);

            foreach (var item in dadosCopiados)
            {
                Console.WriteLine($"|{item}|");
            }


        }
    }
}
