using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao22
    {
        public static Hashtable CadastroDeCarro()
        {
            Hashtable dadosDaMontadoras = new Hashtable();
            ArrayList dadosDoCarro = new ArrayList { "Mille", "Novo Uno", "Palio", "Siena", "Freemont", "Bravo", "Punto", "Linea", "Palio Weekend" };

            dadosDaMontadoras.Add("Fiat", dadosDoCarro);

            dadosDoCarro = new ArrayList { "Gol", "Voyage", "Polo", "Passat", "Amarok", "Fox", "Golf", "Jetta", "Tiguan" };

            dadosDaMontadoras.Add("Volkagen", dadosDoCarro);

            dadosDoCarro = new ArrayList { "Focus", "Fiesta", "Ka", "New Fiesta", "Fusion", "Edge" };

            dadosDaMontadoras.Add("Ford", dadosDoCarro);

            dadosDoCarro = new ArrayList { "Celta", "Classic", "Prisma", "Agile", "Omega", "Cruze", "Camaro", "Malibu" };

            dadosDaMontadoras.Add("GM", dadosDoCarro);

            return dadosDaMontadoras;



        }
        public static void Rodar()
        {
            Hashtable dadosRecebidos = CadastroDeCarro();
            char continuar;
            do
            {
                Console.Write("Informe o nome da montadora: ");
                string name = Console.ReadLine();

                ArrayList var = new ArrayList((ICollection)dadosRecebidos[name]);

                Console.WriteLine("\n::::::::::::::::::::Veículos::::::::::::::::::::\n\n");

                Console.WriteLine($"Qunatidade de veículos: {var.Capacity}");
                

                foreach (object item in var)
                {
                    Console.Write($"|{item}|");
                }

                Console.Write("\n\nQuer continuar (S-sim/N-não): ");
                continuar = char.Parse(Console.ReadLine());

                Console.WriteLine();

            } while (continuar == 'S' || continuar == 's');
            

            

        }
    }
}
