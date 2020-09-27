using System;
using System.Collections;
using TrabalhoAED.Questoes;

namespace TrabalhoAED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1 a 33: ");
            int escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1:
                    Questao1.Rodar();
                    break;
                case 2:
                    Questao2.Rodar();
                    break;
                case 3:
                    Questao3.Rodar();
                    break;
                case 4:
                    Questao4.Rodar();
                    break;
                case 5:
                    Questao5.Rodar();
                    break;
                case 6:
                    Questao6.Rodar();
                    break;
                case 7:
                    Questao7.Rodar();
                    break;
                case 8:
                    Questao8.Rodar();
                    break;
                case 9:

                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    Questao12.Rodar();
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    Questao18.Rodar();
                    break;
                case 19:
                    Questao19.Rodar();
                    break;
                case 20:
                    break;
                case 21:
                    Questao21.Rodar();
                    break;

                case 22:
                    Questao22.Rodar();
                    break;
                case 23:
                    break;
                case 24:
                    Questao24.Rodar();
                    break;
                case 25:
                    Questao25.Rodar();
                    break;
                case 26:
                    Questao26.Rodar();
                    break;
                case 27:
                    Questao27.Rodar();
                    break;
                case 28:
                    Questao28.Rodar();
                    break;
                case 29:
                    Questao29.Rodar();
                    break;
                case 30:
                    Questao30.Rodar();
                    break;
                case 31:
                    Questao31.Rodar();
                    break;
                case 32:
                    break;
                case 33:
                    Questao33.Rodar();
                    break;


                default:
                    Console.WriteLine("Não tem essa questão.");
                    break;
            }

        }
    }
}
