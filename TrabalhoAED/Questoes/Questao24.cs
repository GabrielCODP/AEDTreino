using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao24
    {
        public static int QtdeOcorrencias(List<string> origem,string elemento)
        {
            int quantidade = 0;
            foreach (string item in origem)
            {
                if (item == elemento) 
                    quantidade++;
            }


            return quantidade;

        }

        public static void Rodar()
        {
            List<string> dados = new List<string> { "Bolo", "Café", "Books", "Dados", "Cacau", "Mega Driver", "Work", "Café", "Work", "Mega Driver", "Work", "Bolo" };

            Console.Write("Informe o elemento: ");
            string elemento = Console.ReadLine();

            int quantidadeElementos = QtdeOcorrencias(dados, elemento);

            Console.WriteLine($"Quantidade de elementos: {quantidadeElementos}");

            foreach (string item in dados)
            {
                Console.Write($"|{item}|");
            }

        }
    }
}
