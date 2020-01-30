using System;

namespace VKO_38_KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int haettu = 124;
            int i = 0;
            int annettu = 0;

            Console.WriteLine("Arvaappa lukua väliltä 1-500: ");
            annettu = int.Parse(Console.ReadLine());
            

            while (annettu != haettu) 
            {
                if (annettu > 500 || annettu < 1)
                {
                    Console.WriteLine("Luku ei ollut väliltä 1-500, tätä yritystä ei lasketa.");
                    Console.WriteLine("Yritä arvata uudestaan: ");
                    annettu = int.Parse(Console.ReadLine());
                }
                else if (annettu > haettu)
                {
                    i++;
                    Console.WriteLine("Annoit liian ison luvun, yritä uudestaan: ");
                    annettu = int.Parse(Console.ReadLine());

                }
                else if (annettu < haettu)
                {
                    i++;
                    Console.WriteLine("Annoit liian pienen luvun, yritä uudestaan: ");
                    annettu = int.Parse(Console.ReadLine());

                }
            }
            i++;
            Console.WriteLine("Oikien, arvasit luvun {0} kerralla", i);
            
        }
    }
}


/*
 Laita vakioon ARVATTAVA_LUKU joku arvo väliltä 1-500.

Tee ohjelma, joka pyytää arvaamaan lukua. Jos käyttäjä syötti isomman luvun kuin vakiossa, niin tulosta : Annoit liian ison luvun
Jos taas käyttäjän syöttämä luku oli pienempi kuin vakion luku niin tulosta : Annoit liian pienen luvun.

Kun käyttäjä arvaa luvun oikein niin tulosta : Oikein, arvasit luvun 27 kerralla!

Missä siis arvo 27 kertoo montako kierrosta meni ennenkuin käyttäjä arvasi oikein

 */
