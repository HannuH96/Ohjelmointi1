using System;

namespace VKO_40_KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testi;
            testi = KysyJaTestaaLuku();

            switch(testi)
            {
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;

                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;

                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;

            }
        }

        static int KysyJaTestaaLuku()
        {
            int luku;

            Console.Write("Anna luku:");
            luku = int.Parse(Console.ReadLine());

            if(luku > 0)
            {
                return 1;
            }
            else if (luku == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}


/*
 Tee ohjelma, jossa kysytään  KysyJaTestaaLuku() nimisessä funktiossa  käyttäjältä kokonaisluku. 

Funktio palauttaa kokonaislukuarvon seuraavasti:
   1 Syötetty luku on positiivinen. - jep
   0 Syötetty luku on nolla. - jep
 -1 Syötetty luku on negatiivinen. - jep

Tulosta näiden paluuarvojen perusteella mainissa (pääohjelmassa) ilmoitus ruudulle.
”Luku oli positiivinen”, jos paluuarvo oli 1. - jep
”Luku oli nolla”, jos paluuarvo oli 0 - jep
”Luku oli negatiivinen”, jos paluuarvo oli -1. - jep


Käyttäkää main:ssa switch-case-rakennetta */
