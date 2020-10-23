using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao13
    {
        static Stack CopiaStack(Stack Origem)
        {
            Queue dadosTemp = new Queue(Origem);

            Stack dadosReturn = new Stack(dadosTemp);

            return dadosReturn;
        }
        public static void Rodar()
        {
            Stack dados = new Stack();
          
            for (int i = 0; i <= 10; i++)
            {
                dados.Push(i);
            }

            foreach (object item in dados)
            {
                Console.Write($"|{item}|");
            }

            Stack newDados = new Stack(CopiaStack(dados));

            Console.WriteLine("\n::::::::::::::Novo Stack copiado::::::::::::::");

            foreach (object item in newDados)
            {
                Console.Write($"|{item}|");
            }
        }
    }
}
