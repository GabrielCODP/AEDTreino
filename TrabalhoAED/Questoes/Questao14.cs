using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao14
    {
        static void VaiProFundo(Stack origem, object elemento)
        {
            Stack temp = new Stack(origem);
            Stack newDados = new Stack();
            newDados.Push(elemento);

            foreach (object item in temp)
            {
                newDados.Push(item);
            }

            foreach (object item in newDados)
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

            Console.Write("Informe o elemento para ir para o fundo do stack: ");
            int elemento = int.Parse(Console.ReadLine());

            VaiProFundo(dados, elemento);
        }
    }
}
