using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VKO_41_KT3
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length == 0) //parametreja ei ole, virheilmo
            {
                Console.WriteLine("Main-funktiolla ei ole parametrejä");
            }
            else //Jos Main-funktioon tuli parametreja niin... 
            {
                Tallenna(args);
                LueJaTulosta();
            }
        }

        static void Tallenna(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\temp\\parametrit.txt"); //...kirjoita tulleet parametrit ”parametrit.txt” tiedostoon allekkain.
            int i;

            for (i = 0; i < args.Length; i++) 
            {
                sw.WriteLine("{0}", args[i]);
            }


            sw.Close();
        }

        static void LueJaTulosta() 
        {
            StreamReader sr = new StreamReader("C:\\temp\\parametrit.txt");

            while (sr.EndOfStream == false) 
            {
                Console.WriteLine(sr.ReadLine()); //Luetaan ja tulostetaan...
            }
        }


    }
}

/*
Jos Main-funktioon ei tullut yhtään parameteriä (0 kpl), 
niin silloin ohjelma päättyy ja tulostuu joku virheilmoitus. 
Jos Main-funktioon tuli parametreja niin kirjoita tulleet parametrit ”parametrit.txt” tiedostoon allekkain.
Sen jälkeen lue tiedostosta sinne kirjoitetut tiedot rivi kerrallaan ja tulosta näytölle.


 

Käytä funktioita:

Tallenna

LueJaTulosta
 */
