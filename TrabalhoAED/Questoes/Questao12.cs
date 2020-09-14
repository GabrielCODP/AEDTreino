using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao12
    {
        public static Queue CopiaQueue(Queue origem)
        {
            Queue copia = new Queue(origem);

            return copia;

        }
        public static void Rodar()
        {
            Queue dados = new Queue();

            for (int i = 0; i < 15; i++)
            {
                dados.Enqueue(i + 1);
            }

            Queue novosDados = CopiaQueue(dados);

            foreach (int item in novosDados)
            {
                Console.Write($"|{item}|");
            }
        }
    }
}
