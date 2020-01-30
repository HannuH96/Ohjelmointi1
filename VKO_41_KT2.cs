using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VKO_41_KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] taulu = new double[40]; ////luo 40 alkioinen double-taulukko
            ArvoJaTallennaTiedostoon();
            LueTiedostosta(taulu);
            TulostaTiedot(taulu);
        }

        static void ArvoJaTallennaTiedostoon()
        {
            int i;
            double k;
            Random rng = new Random();
            StreamWriter sw = new StreamWriter("C:\\temp\\datat.txt");

            for (i = 0; i < 40; i++)
            {
                k = (rng.NextDouble() * (5.8 - 1.4)) + 1.4; // Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8
                sw.WriteLine(k); //kirjoita ne datat.txt tiedostoon allekkain
            }

            sw.Close();
        }

        static void LueTiedostosta(double[] taulu) 
        {
            int i=0;
            StreamReader sr = new StreamReader("C:\\temp\\datat.txt");

                while (sr.EndOfStream == false)
                {
                    
                    taulu[i] = double.Parse(sr.ReadLine()); //ja lue arvot tiedostosta taulukkoon
                    i++;
                }
 
        }

        static void TulostaTiedot(double[] taulu) //Tämän jälkeen tulosta taulukon lukujen summa, keskiarvo, minimiarvo ja maksimiarvo.
        {
            Console.WriteLine("Arvottujen summa: {0}", taulu.Sum());
            Console.WriteLine("Arvottujen keskiarvo: {0}", taulu.Average());
            Console.WriteLine("Arvottujen minimiarvo: {0}", taulu.Min());
            Console.WriteLine("Arvottujen maksimiarvo: {0}", taulu.Max());

        }
    }
}
/*
 Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne datat.txt tiedostoon allekkain. Älä käytä taulukkoa tässä vaiheessa.


Sen jälkeen luo 40 alkioinen double-taulukko 
ja lue arvot tiedostosta taulukkoon. 
Tämän jälkeen tulosta taulukon lukujen summa, keskiarvo, minimiarvo ja maksimiarvo.


Käytä funktioita:

ArvoJaTallennaTiedostoon

LueTiedostosta

TulostaTiedot
*/
