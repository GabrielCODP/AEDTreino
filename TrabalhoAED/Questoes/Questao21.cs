using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao21
    {
        public static SortedList Cadastro()
        {
            SortedList dadosAlunos = new SortedList();
            string nome;
            int matricula;

            do
            {
                Console.WriteLine("\n::::::::::::::::::::::::::::::");
                Console.Write("\nInforme o nome do aluno: ");
                nome = Console.ReadLine();
                Console.Write("Informe a matrícula: ");
                matricula = int.Parse(Console.ReadLine());

                if (matricula >= 0)
                    dadosAlunos.Add(matricula, nome);

            } while (matricula >= 0);

            return dadosAlunos;
        }
        public static void Rodar()
        {
            SortedList dadosDeCadastro = Cadastro();
            int pesquisarMatricula;

            Console.WriteLine("\n:::::::::::Pesquisa da matrícula:::::::::::::::");
            do
            {
                Console.Write("\nInforme o número matrícula: ");
                pesquisarMatricula = int.Parse(Console.ReadLine());

                string value = (string)dadosDeCadastro[pesquisarMatricula];

                Console.WriteLine("Aluno: " + value);

            } while (pesquisarMatricula >= 0);

        }
    }
}
