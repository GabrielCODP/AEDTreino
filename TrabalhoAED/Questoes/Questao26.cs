using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
   public static class Questao26
   {
        static Queue CopiaQueue(Queue<int> origem)
        {
            Queue newDados = new Queue(origem);

            return newDados;
        }
        public static void Rodar()
        {
            Queue<int> dados = new Queue<int>();

            for (int i = 0; i < 20; i++) 
            {
                dados.Enqueue(i);
            }

            Queue<int> DadosCopiados = new Queue<int>(dados);

            foreach (object item in DadosCopiados)
            {
                Console.Write($"|{item}|");
            }


        }
   }
}
