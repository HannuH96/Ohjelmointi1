using System;
using System.Linq;


namespace VKO_39_KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[8]; //Esittele kahdeksan (8) alkioinen lotto-taulukko
            int i,k;
            int test = 0;
            int test2 = 0;
            Random rng = new Random();

                for (i = 0; i < lotto.Length; i++) //ja arvo siihen lottonumerot 
                {
                    lotto[i] = rng.Next(1, 41);
                    test++;
                    if (i == 7) // koska Distinct().Count() laskee nollan, on tämä if-hommeli tarpeellinen (Tässä tuli päätä seinään hakatuksi hetki :) )
                    {
                        test2 = lotto.Distinct().Count();
                    }
                    else
                    {
                        test2 = lotto.Distinct().Count() - 1;
                    }

                    if (test > test2) //Muista, että samaa numeroa ei saa tulla lottoriviin...
                    {
                        test--;
                        i--;

                    }
                }



                Array.Sort(lotto, 0, 7);

                for (i = 0; i < (lotto.Length - 1); i++) //Tulosta lopuksi lottorivi...
                {
                    Console.Write("{0}  ", lotto[i]);
                }

                Console.Write("+  {0}", lotto[7]); //Lisänumero tarvitsee sen plussan.
            
        }
    }
}

/*
 Lotossa arvotaan seitsemän (7) varsinaista numeroa ja yksi (1) lisänumero. Numerot ovat väliltä 1-40.

Esittele kahdeksan (8) alkioinen lotto-taulukko - jep
ja arvo siihen lottonumerot  - jep
Muista, että samaa numeroa ei saa tulla lottoriviin eli mieti miten voisit tarkistaa onko arvottu numero jo lottorivissä entuudestaan ja silloin sen tilalle pitää arpoa uusi numero. - jep

Tulosta lopuksi lottorivi seuraavasti: 1  4  12  16  19  25  31  +  13 - jep

HUOM!! seitsemän varsinaista numeroa on lajiteltu suuruusjärjestykseen! - jep
*/