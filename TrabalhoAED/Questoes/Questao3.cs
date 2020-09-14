using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao3
    {
        public static ArrayList CopiaParteArrayList(ArrayList origem, int inicio, int final)
        {
            ArrayList dadosCopiados = new ArrayList();

            if (final > origem.Count)
                dadosCopiados = origem;
            else if (inicio > origem.Count)
            {
                //Vazio?
            }
            else if (inicio > final) 
            {
                dadosCopiados = origem;
                dadosCopiados.Reverse();
            }
            else
            {
                dadosCopiados = origem;
                dadosCopiados = dadosCopiados.GetRange(inicio, final);
            }    
        
            return dadosCopiados;
        }
        public static void Rodar()
        {
            ArrayList origem = new ArrayList { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            ArrayList retorno = new ArrayList();

            Console.Write("Informe o  parâmetro inicial: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Informe o  parâmetro final: ");
            int final = int.Parse(Console.ReadLine());

            retorno = CopiaParteArrayList(origem, inicio, final);

            foreach (int item in retorno)
            {
                Console.Write($"|{item}|");
            }



        }
    }
}
