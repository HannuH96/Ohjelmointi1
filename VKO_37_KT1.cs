using System;

namespace VKO_37_KT1
{
    class Program
    {
        static void Main()
        {
            double lampotila;

            //Pyydetään lämpötila

            Console.WriteLine("Anna lämpötila");
            lampotila = double.Parse(Console.ReadLine());


            //Vertaillaan. 
            //Olinpa hölmö ensin, käytin ||, kun piti käyttää &&... 

            if (lampotila > 39)
            {
                Console.WriteLine("Liian kuuma");
            }
            else if (lampotila >= 11 && lampotila <= 39)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (lampotila >= 0 && lampotila <= 10)
            {
                Console.WriteLine("Haaleaa");
            }
            else if (lampotila >= -30 && lampotila <= -1)
            {
                Console.WriteLine("Pakkasta");
            }
            else
            {
                Console.WriteLine("Liian kylmää");
            }
        }
    }
}

/*
Tee ohjelma, joka pyytää käyttäjää syöttämään lampotila -nimiseen muuttujaan jonkin mielivaltainen lämpötilan arvon.

Ohjelma tulostaa sitten seuraavasti, kun lämpötila on:

> 39 tulostuu : Liian kuuma
11..39 tulostuu : Lämmintä
0..10 tulostuu : Haaleaa
-30..-1 tulostuu : Pakkasta
< -30 tulostuu : Liian kylmää


*/