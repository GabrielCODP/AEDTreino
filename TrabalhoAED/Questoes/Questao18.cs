using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao18
    {
        static Hashtable Dados()
        {
            Hashtable dados = new Hashtable();
            dados.Add("UUU", "Fenilalanina");
            dados.Add("UUC", "Fenilalanina");
            dados.Add("UUA", "Leucina");
            dados.Add("UUG", "Leucina");
            dados.Add("UCU", "Serina");
            dados.Add("UCC", "Serina");
            dados.Add("UCA", "Serina");
            dados.Add("UCG", "Serina");
            dados.Add("UAU", "Tirosina");
            dados.Add("UAC", "Tirosina");
            dados.Add("UAA", "Parada");
            dados.Add("UAG", "Parada");
            dados.Add("UGU", "Cisteína");
            dados.Add("UGC", "Cisteína");
            dados.Add("UGA", "Parada");
            dados.Add("UGG", "Triptofano");
            dados.Add("CUU", "Leucenina");
            dados.Add("CUC", "Leucenina");
            dados.Add("CUA", "Leucenina");
            dados.Add("CUG", "Leucenina");
            dados.Add("CCU", "Prolina");
            dados.Add("CCA", "Prolina");
            dados.Add("CCG", "Prolina");
            dados.Add("CAU", "Histidina");
            dados.Add("CAC", "Histidina");
            dados.Add("CAA", "Glutamina");
            dados.Add("CAG", "Glutamina");
            dados.Add("CGU", "Arginina");
            dados.Add("CGC", "Arginina");
            dados.Add("CGA", "Arginina");
            dados.Add("CGG", "Arginina");
            dados.Add("AUU", "Isoleucina");
            dados.Add("AUC","Isoleucina");
            dados.Add("AUA", "Isoleucina");
            dados.Add("AUG", "Isoleucina");
            dados.Add("ACU", "Treonina");
            dados.Add("ACC", "Treonina");
            dados.Add("ACA", "Treonina");
            dados.Add("ACG", "Treonina");
            dados.Add("AAU", "Asparagina");
            dados.Add("AAC", "Asparagina");
            dados.Add("AAA", "Lisina");
            dados.Add("AAG", "Lisina");
            dados.Add("AGU", "Serina");
            dados.Add("AGC", "Serina");
            dados.Add("AGA", "Arginina");
            dados.Add("AGG", "Arginina");
            dados.Add("GUU", "Valina");
            dados.Add("GUC", "Valina");
            dados.Add("GUA", "Valina");
            dados.Add("GUG", "Valina");
            dados.Add("GCU", "Alanina");
            dados.Add("GCC", "Alanina");
            dados.Add("GCA", "Alanina");
            dados.Add("GCG", "Alanina");
            dados.Add("GAU", "Aspartato");
            dados.Add("GAC", "Aspartato");
            dados.Add("GAA", "Glutamato");
            dados.Add("GAG", "Glutamato");
            dados.Add("GGU", "Glicina");
            dados.Add("GGC", "Glicina");
            dados.Add("GGA", "Glicina");
            dados.Add("GGG", "Glicina");



            return dados;
        }

        public static void Rodar()
        {
            Hashtable dadosIniciados = Dados();
            char resp;

            do
            {
                Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::");

                Console.Write("\nInforme a trinca: ");
                string trinca = Console.ReadLine();

                string value = (string)dadosIniciados[trinca];

                if (value != null)
                    Console.WriteLine($"\nAminoácido:{value}");

                else
                    Console.WriteLine("\nO aminoácido não existe!");

                Console.Write("\nDeseja continuar a informa a trinca (S-sim/N-não): ");
                resp = char.Parse(Console.ReadLine());


            } while (resp == 'S' || resp == 's');


        }
    }
}
