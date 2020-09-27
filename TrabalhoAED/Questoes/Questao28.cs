using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao28
    {
        static void VaiproFundo<T>(Stack<T> origem, T elemento)
        {
            List<T> temporario = new List<T>(origem);
            temporario.Add(elemento);

            origem.Clear();

            foreach (T item in temporario)
            {
                origem.Push(item);
                Console.WriteLine(item);
            }
            
        }

        public static void Rodar()
        {
            Stack<int> dados = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                dados.Push(i);
            }

            Console.Write("Informe o elemento : ");
            int elemento = int.Parse(Console.ReadLine());

            VaiproFundo(dados, elemento);
        }
    }
}
