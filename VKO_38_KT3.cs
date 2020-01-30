using System;

namespace VKO_38_KT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mista = 0;
            int mihin = 1;
            int step = 0;
            int i = 0;

            while (i <= mihin) //Tähän laitetaan silmukka aloittamaan alusta jos luvut on väärin. Negatiiviset luvut aiheutti ongelman...
            {



                Console.WriteLine("Mistä luvusta tulostetaan?");
                mista = int.Parse(Console.ReadLine());
                Console.WriteLine("Mihin asti tulostetaan?");
                mihin = int.Parse(Console.ReadLine());
                Console.WriteLine("Millaisella askelluksella tulostetaan?");
                step = int.Parse(Console.ReadLine());

                if (step > 0 && mista < mihin)  //Tarkistetaan onko luvut annettu oikein
                {
                    i = mista; //mista muuttujaa käytetään muissakin silmukoissa, tarvitaan toinen muuttuja laskuja varten.
                    Console.Write("Do-while silmukka: ");
                    do
                    {


                        Console.Write("{0} ", i);

                        i = i + step; 

                    }
                    while (i <= mihin);

                    Console.Write("\n\nWhile silmukka: ");
                    i = mista;

                    while (i <= mihin) //Samat jutut kuin edellisessä silmukassa...
                    {
                        Console.Write("{0} ", i);

                        i = i + step;
                    }


                    Console.Write("\n\nFor silmukka: ");

                    for (i = mista; i <= mihin; i = i + step) // Siirrettiin lasku sulkuihin muutujan kasvatuspaikkaan 
                    {
                        Console.Write("{0} ", i);
                    }
                }
                else //Jos luvut väärin.. palataan alkuun. Tätä sai hetken miettiä.
                {
                    Console.WriteLine("Luvut annettu väärin, alkuluvun täytyy olla pienempi, kuin loppuluvun, ja askel ei voi olla nolla.\n");
                    i = mihin; //Tämä korjaa negatiivisten lukujen aiheuttaman ohjelman päättymisen.
                }
            }

        }
    }
}

/*
 Kysy käyttäjältä mistä luvusta tulostetaan ja mihin asti ja millaisella askelluksella. 
 HUOM! Mistä oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0. Muuten kysyttävä tiedot uudestaan.

Tulosta lukusarjat sekä while-, do-while- että for-silmukoilla

Esimerkki:

Jos mistä on vaikka 5, mihin on vaikka 11 ja askellus on vaikka 2, niin ohjelma tulosta kaikilla 3 silmukalla lukusarjan (voi tulostaa myös allekkain...)

5   7   9   11

PALAUTA VAIN CS-TIEDOSTOT JOKAINEN OMANA TIEDOSTONAAN (3 KPL)!
     */
