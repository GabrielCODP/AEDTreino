using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoAED.Questoes
{
    public static class Questao19
    {
        static Hashtable DicionarioURL()
        {
            Hashtable dadosSites = new Hashtable();

            dadosSites.Add("www.google.com", "74.125.234.81");
            dadosSites.Add("www.pucminas.com.br", "200.229.32.27");
            dadosSites.Add("www.gmail.com", "172.217.29.101");
            dadosSites.Add("www.youtube.com", "172.217.29.110");
            dadosSites.Add("www.capes.gov.br", "200.130.18.222");
            dadosSites.Add("www.yahoo.com", "74.6.143.26");
            dadosSites.Add("www.microsoft.com", "23.216.173.71");
            dadosSites.Add("www.twitter.com", "104.244.45.65]");
            dadosSites.Add("www.brasil.gov.br", "170.246.255.242");
            dadosSites.Add("www.wikipedia.com", "208.80.153.232");
            dadosSites.Add("www.amazon.com", "13.33.130.223");
            dadosSites.Add("research.microsoft.com", "13.67.218.189");
            dadosSites.Add("www.facebook.com", "31.13.74.35");
            dadosSites.Add("www.whitehouse.gov", "23.216.184.2327");
            dadosSites.Add("www.answers.com", "151.101.92.203]");
            dadosSites.Add("www.uol.com.br", "99.84.22.115]");
            dadosSites.Add("www.hotmail.com", "204.79.197.212");
            dadosSites.Add("www.cplusplus.com", "144.217.110.12");
            dadosSites.Add("www.nyt.com", "151.101.93.164");
            dadosSites.Add("www.apple.com", "23.216.189.228");
            dadosSites.Add("www.udemy.com", "104.16.92.52");
            dadosSites.Add("github.com", "140.82.114.4");
            dadosSites.Add("www.primevideo.com", "13.33.130.160");
            dadosSites.Add("www.kabum.com.br", "13.33.121.60");
            dadosSites.Add("www.clubedohardware.com.br", "104.26.9.248");


            return dadosSites;
        }
        public static void Rodar()
        {
            Hashtable dado = DicionarioURL();
            char resp;

            do
            {
                Console.Write("\nInforme a URL: ");
                string url = Console.ReadLine();

                if (url != null)
                {
                    string value = (string)dado[url];
                    Console.Write($"IP: {value}");
                }
                else
                    Console.WriteLine("A URL não existe!");

                Console.Write("\n\nDeseja continuar (S-sim/N-não): ");
                resp = char.Parse(Console.ReadLine());

            } while (resp == 'S' || resp == 's');
        }
    }
}
