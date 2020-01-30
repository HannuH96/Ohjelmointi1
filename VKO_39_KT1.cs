using System;

namespace VKO_39_KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int i;

            Console.WriteLine("Kirjoita pitkähkö teksti: ");
            text = Console.ReadLine(); //Lue käyttäjältä pitkähkö teksti string muuttujaan.

            text = text.ToUpper(); //Muuta kaikki kirjaimet isoiksi kirjaimiksi 
            Console.WriteLine("{0}", text); //ja tulosta muutettu teksti.

            text = text.Replace("A", "!"); //Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti
            Console.WriteLine("{0}", text);

            text = text.Replace(" ", ""); //Poista kaikki välilyönnit ja tulosta teksti
            Console.WriteLine("{0}", text);

            for(i = 0; i < text.Length; i++) //Tulosta lopuksi kaikki merkit lopusta alkuun yhdellä välilyönnillä eroteltuna
            {
                Console.Write("{0} ", text[i]); 
            }

        }
    }
}

/*
 

Lue käyttäjältä pitkähkö teksti string muuttujaan. - jep

- Muuta kaikki kirjaimet isoiksi kirjaimiksi ja tulosta muutettu teksti. - jep
- Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti - jep
- Poista kaikki välilyönnit ja tulosta teksti - jep

Tulosta lopuksi kaikki merkit lopusta alkuun yhdellä välilyönnillä eroteltuna - jep
*/
