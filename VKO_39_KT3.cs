using System;
using System.Linq;


namespace VKO_39_KT3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] taulu = new double[5,4]; //Esittele sellainen 2-ulottoinen taulukko
            int i, j;
            
            

            for (i = 0; i < taulu.GetLength(0); i++) 
            {
                for (j = 0; j < taulu.GetLength(1); j++) 
                {
                    Console.WriteLine("Anna {0}: päivän mittaustulos #{1}", i+1, j+1); // Lue käyttäjältä nämä mittaustulokset taulukkoon
                    taulu[i, j] = double.Parse(Console.ReadLine());
                    
                }
            }
            // tulosta lopuksi jokaisen päivän mittaustulosten keskiarvo esimerkin mukaisesti.
            // On ruma, mutta juuri nyt ei aivot toimi tarvittavalla tavalla.
            double ka = (taulu[0, 0] + taulu[0, 1] + taulu[0, 2] + taulu[0, 3]) / 4;
            Console.WriteLine("Maanantai: {0:f1} mm", ka);

            double ka2 = (taulu[1, 0] + taulu[1, 1] + taulu[1, 2] + taulu[1, 3]) / 4;
            Console.WriteLine("Tiistai: {0:f1} mm", ka2) ;

            double ka3 = (taulu[2, 0] + taulu[2, 1] + taulu[2, 2] + taulu[2, 3]) / 4;
            Console.WriteLine("Keskiviikko: {0:f1} mm", ka3);

            double ka4 = (taulu[3, 0] + taulu[3, 1] + taulu[3, 2] + taulu[3, 3]) / 4;
            Console.WriteLine("Torstai: {0:f1} mm", ka4);

            double ka5 = (taulu[4, 0] + taulu[4, 1] + taulu[4, 2] + taulu[4, 3]) / 4;
            Console.WriteLine("Perjantai: {0:f1} mm", ka5);

        }
    }
}

/*
 Esittele sellainen 2-ulottoinen taulukko, - jep
 johon voit tallentaa maanantain ja perjantain välisenä aikana neljä mittaustulosta jokaiselta päivältä (mittaustulos on sademäärä milleinä).

Lue käyttäjältä nämä mittaustulokset taulukkoon ja 
tulosta lopuksi jokaisen päivän mittaustulosten keskiarvo esimerkin mukaisesti
vkpv: arvo
vkpv2: arvo2...
*/
