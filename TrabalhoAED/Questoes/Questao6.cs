using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
   public static  class Questao6
   {
        public static ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2)
        {
            ArrayList retorno = new ArrayList(AL1);
            retorno.AddRange(AL2);

            return retorno;
        }
        public static void Rodar()
        {
            ArrayList A = new ArrayList { 19, 33, 2, 4 };
            ArrayList B = new ArrayList { 1, 2, 3, 4, 5 };
            ArrayList AmaisB = new ArrayList(ConcatenaArrayList(A,B));

            Console.WriteLine(":::::::::::::::::::AmaisB:::::::::::::::::::\n");
            foreach (object item in AmaisB)
            {
                Console.Write($"|{item}|");
            }

        }
   }
}
