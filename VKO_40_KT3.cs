using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO_40_KT3
{
    class Program
    {
        static void Main()
        {
            double[] pisteet;
            double pituus, tulos;

            pisteet = new double[5];


            KysyHypynPituus(out pituus);

            KysyTuomareidenPisteet(pisteet);

            LaskeHypynPisteet(pisteet, pituus, out tulos);

            Tulosta(pituus, tulos);


        }
        static void KysyHypynPituus(out double pituus) //Ohjelma kysyy hypyn pituuden (liukuluku 0.5 metrin välein) 
        {
            bool test;
            Console.Write("Anna hypyn pituus: ");
            test = double.TryParse(Console.ReadLine(), out pituus);

            while(test==false)
            {
                Console.Write("Annoit jotain muuta kuin pituus-arvon, yritä uudestaan.\n\nAnna hypyn pituus: ");
                test = double.TryParse(Console.ReadLine(), out pituus);
            }
            pituus = Math.Round(pituus * 2) / 2; //pyöristetään arvo.


        }

        static void KysyTuomareidenPisteet(double[] pisteet)
        {
            int i;
            bool test;
            for (i = 0; i < pisteet.Length; i++) //sekä viiden arvostelutuomarin tyylipisteet
            {
                Console.Write("Anna tuomarin #{0} antamat pisteet väliltä 0-20: ", i + 1);
                test = double.TryParse(Console.ReadLine(), out pisteet[i]);
                while (test == false || pisteet[i] < 0 || pisteet[i] > 20) 
                {
                    Console.Write("Annoit jotain muuta kuin sallitun arvon.\n\nYritä uudestaan.\n\nAnna tuomarin #{0} antamat pisteet väliltä 0-20: ", i + 1);
                    test = double.TryParse(Console.ReadLine(), out pisteet[i]);
                } 

                pisteet[i] = Math.Round(pisteet[i] * 2) / 2; //pyöristetään... jotta luku päättyy .0 tai .5
            }
        }

        static void LaskeHypynPisteet(double[] pisteet, double pituus, out double tulos)
        {
            tulos = (pituus - 90) * 1.8 + (pisteet.Sum() - pisteet.Max() - pisteet.Min()) + 60; //Kaava

        }
        
        static void Tulosta(double pituus, double tulos) //Tulosta lopuksi hypyn pituus ja hypyn pisteet

        {
            Console.WriteLine("Hypyn pituus oli {0} ja pisteet {1}", pituus, tulos);
        }

    }
}


/*


Ohjelma kysyy hypyn pituuden (liukuluku 0.5 metrin välein) -jep
sekä viiden arvostelutuomarin tyylipisteet (0-20 välillä 0.5 välein eli esim. 16.5 tai 17.0 tai 18.5) -jep

    kaava
pisteet = (hypyn pituus - kriittinen piste)*1,8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. - jep


Tulosta lopuksi hypyn pituus ja hypyn pisteet

Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään):


KysyHypynPituus
KysyTuomareidenPisteet
LaskeHypynPisteet
Tulosta
*/
