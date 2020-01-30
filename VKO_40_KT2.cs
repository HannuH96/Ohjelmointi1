using System;

namespace VKO_40_KT2
{
    class Program
    {
        static void Main()
        {
            int[] taulu;
            int koko, hylatyt;

            koko = KysyKoko();

            taulu = LuoTaulukko(koko);

            ArvoArvosanat(taulu);

            hylatyt = TutkiHylatyt(taulu);

            Tulosta(hylatyt);

        }

        static int KysyKoko()
        {
            int koko;
            bool test;

            Console.Write("Anna taulukolle koko: "); // Kysy käyttäjältä kuinka iso taulukko luodaan. 
            test = int.TryParse(Console.ReadLine(), out koko);

            do
            {
                Console.Write("Annoit jotain väärin\n\nAnna taulukolle koko: "); // Kysy käyttäjältä kuinka iso taulukko luodaan. 
                test = int.TryParse(Console.ReadLine(), out koko);
            } while (test == false);

            return koko;

        }
        static int[] LuoTaulukko(int koko) //Luo taulukko 
        {
            int[] taulu = new int[koko];
            return taulu;
        }
        static void ArvoArvosanat(int[] taulu) // ja arvo siihen arvosanoja väliltä 0-5. 
        {
            int i;
            Random rng = new Random();
            for (i = 0; i < taulu.Length; i++)
            {
                taulu[i] = rng.Next(0, 6);
            }
        }

        static int TutkiHylatyt(int[] taulu) // Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0.
        {
            int i;
            int hylatyt = 0;
            for (i = 0; i < taulu.Length; i++)
            {
                if (taulu[i] == 0)
                {
                    hylatyt++;
                }
            }

            return hylatyt;
        }

        static void Tulosta(int hylatyt) // Tulosta määrä näytölle.
        {
           
            Console.WriteLine("Hylattyjen arvosanojen määrä: {0}", hylatyt);

        }

    }
}

/*
 Kysy käyttäjältä kuinka iso taulukko luodaan. -jep
 Luo taulukko -jep
 ja arvo siihen arvosanoja väliltä 0-5. -jep
 Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0. - jep
 Tulosta määrä näytölle. - jep

Käytä ohjelmassa seuraavia funktioita:


KysyKoko
LuoTaulukko
ArvoArvosanat
TutkiHylatyt
Tulosta
*/