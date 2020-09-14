using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao2
    {
        public static ArrayList CopiaQueueParaArrayList(Queue origem)
        {
            ArrayList dadosCopiados = new ArrayList(origem);

            return dadosCopiados;
        }
        public static void Rodar()
        {
            Queue dados = new Queue();
            ArrayList copiaDoQueue = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                dados.Enqueue(i);
            }

            copiaDoQueue = CopiaQueueParaArrayList(dados);

            foreach (var item in copiaDoQueue)
            {
                Console.WriteLine($"|{item}|");
            }
        }
    }
}
