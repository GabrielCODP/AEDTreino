using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao11
    {
        static int QtdeOcorrencias(ArrayList AL, object elemento)
        {
            int cont = 0;

            foreach (object item in AL)
            {
                if ((int)elemento == (int)item)
                    cont++;
            }

            return cont;

        }
        public static void Rodar()
        {
            ArrayList dados = new ArrayList() { 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            Console.Write("Informe o elemento:");
            int elemento = int.Parse(Console.ReadLine());

            Console.Write($"\nQuantidades de elementos do número {elemento} é: {QtdeOcorrencias(dados, elemento)}");
        }
    }
}
