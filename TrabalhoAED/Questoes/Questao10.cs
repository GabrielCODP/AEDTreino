using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao10
    {
        static ArrayList OcorrenciasDe(ArrayList AL, object elemento)
        {
            ArrayList posicoes = new ArrayList();
            int pos = 0;

            foreach (object item in AL)
            {
                if ((int)item == (int)elemento) 
                {
                    posicoes.Add(pos);
                }

                pos++;
            }

            return posicoes;
        }
        public static void Rodar()
        {
            ArrayList dados = new ArrayList() { 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            Console.Write("Informe o objeto a ser retornado as posições: ");
            int obj = int.Parse(Console.ReadLine());

            ArrayList newDados = new ArrayList(OcorrenciasDe(dados, obj));

            Console.WriteLine("::::Posição::::");
            foreach (object item in newDados)
            {
                Console.Write($"|{item}°|");
            }


        }
    }
}
