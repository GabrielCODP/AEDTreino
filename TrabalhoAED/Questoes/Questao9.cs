using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao9
    {
        static void ApagaRepetidos(ArrayList AL)
        {

            Console.WriteLine("::::::::::::::::::ELEMENTOS DO ARRAY ORIGINAL:::::::::::::::::\n");
            foreach (object item in AL)
            {
                Console.Write($"|{item}|");
            }

            for (int i = 0; i < AL.Count; i++)
            {
                object item = AL[i];

                for (int i2 = i + 1; i2 < AL.Count; i2++)
                {
                    if ((int)item == (int)AL[i2])
                        AL.RemoveAt(i2);
                }

            }

            Console.WriteLine("\n::::::::::::::::::ELEMENTOS DO ARRAY SEM REPETIÇÃO:::::::::::::::::\n");

            foreach (object item2 in AL)
            {
                Console.Write($"|{item2}|");
            }

        }
        public static void Rodar()
        {

            ArrayList dados = new ArrayList() { 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            ApagaRepetidos(dados);

        }
    }
}
