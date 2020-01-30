using System;

namespace VKO_37_KT3
{
    class Program
    {
        static void Main()
        {
            float d, tulos;
            int valinta;
            float pii = 3.14159F;

            Console.WriteLine("Anna ympyrän halkaisija: ");
            d = float.Parse(Console.ReadLine());

            Console.Write("Valitse\nPiiri - Paina 1\nPinta-ala - Paina 2\n");
            valinta = int.Parse(Console.ReadLine());
           
           if (valinta == 1)
           {
               tulos = d * pii;
               Console.WriteLine("Ympyrän, jonka halkaisija on {0}, piiri on {1}", d, tulos);
           }
           else if (valinta == 2)
           {
               tulos = (d / 2) * (d / 2) * pii;
               Console.WriteLine("Ympyrän, jonka halkaisija on {0}, pinta-ala on {1}", d, tulos);
           }
           else
           {
               Console.WriteLine("Jokin meni pieleen.");
           }

            /* 
             // Ehtolause

              tulos = ( valinta == 1  ) ? d * pii : (d / 2) * (d / 2) * pii;
              Console.WriteLine(tulos);

             */


        }
    }
}

/*
Lue käyttäjältä ympyrän halkaisija liukulukuna. Kysy käyttäjältä myös, haluaako hän tehdä kumpaa seuraavista (eli käyttäjä syöttää joko numeron 1 tai 2) :

    1 = laske ympyrän piiri
    2 = laske ympyrän pinta-ala

Tämän vastauksen perusteella laske tulos-muuttujaan joko piiri tai pinta-ala ja tulosta se. Toteuta tämä sekä if-rakenteella että ehtolauseella
*/