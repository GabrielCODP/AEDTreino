using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao31
    {
        static SortedList<string, List<string>> CadastroDeCarro()
        {
            SortedList<string, List<string>> dados = new SortedList<string, List<string>>();

            List<string> nomesDados = new List<string> { "Mille", "Novo Uno", "Palio", "Siena", "Freemont", "Bravo", "Punto", "Linea", "Palio Weekend" };
            dados.Add("Fiat", nomesDados);

            nomesDados = new List<string> { "Gol", "Voyage", "Polo", "Passat", "Amarok", "Fox", "Golf", "Jetta", "Tiguan" };

            dados.Add("Volkagen", nomesDados);

            nomesDados = new List<string> { "Focus", "Fiesta", "Ka", "New Fiesta", "Fusion", "Edge" };

            dados.Add("Ford", nomesDados);

            nomesDados = new List<string> { "Celta", "Classic", "Prisma", "Agile", "Omega", "Cruze", "Camaro", "Malibu" };

            dados.Add("GM", nomesDados);


            return dados;
        }
        public static void Rodar()
        {
            try
            {
                SortedList dadosCarros = new SortedList(CadastroDeCarro());
                char escolha;
                do
                {
                    Console.Write("\nInforme o nome da montadora: ");
                    string name = Console.ReadLine();

                    List<string> carrosTemp = new List<string>((List<string>)dadosCarros[name]);


                    Console.WriteLine("\n::::::::::::::::::::Veículos::::::::::::::::::::\n\n");

                    Console.WriteLine($"Quantidade de veículos da {name}: {carrosTemp.Capacity}\n");

                    foreach (var item in carrosTemp)
                    {
                        Console.Write($"|{item}|");
                    }


                    Console.Write("\n\nQuer continuar (S-sim/N-não): ");
                    escolha = char.Parse(Console.ReadLine());

                    Console.WriteLine();


                } while (escolha == 'S' || escolha == 's');

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro no programa!\n" + e);
            }
        }
    }
}
