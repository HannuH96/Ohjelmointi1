using System;

namespace VKO_37_KT2
{
    class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            string oper;
            string error1 = "Annoit operaation, joka ei kelpaa";
            string error2 = "Yritit jakaa nollalla, tuhosit maailman.";

            //Pyydetään arvot ja operaattori

            Console.WriteLine("Anna kaksi lukua: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna operaatio ( +, -, * tai / ): ");
            oper = Console.ReadLine();

            switch(oper)
            {
                case "+":
                    num3 = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}" , num1, num2, num3);
                    break;

                case "-":
                    num3 = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}" , num1, num2, num3);
                    break;

                case "*":
                    num3 = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}" , num1, num2, num3);
                    break;

                case "/":

                    
                    if (num2 !=0) //tarkistetaan onko jakaja nolla
                    {
                        num3 = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}" , num1, num2, num3);
                    }
                    else
                    {
                        Console.WriteLine(error2);
                    }
                    break;
                default:
                    Console.WriteLine(error1);
                    break;

            }

        }
    }
}


/* 
 Lue käyttäjältä kaksi kokonaislukua sekä operaatio joka lukujen välillä suoritetaan 
 (voi olla +, -, * tai / eli kyseessä siis nelilaskin). Käytä operaation tallentamiseen string-tyyppistä muuttujaa tällä kertaa.

Tutki switch-case rakenteessa minkä operaation käyttäjä syötti ja tulosta sen perusteella
lukujen laskutoimitus vastauksineen. Jos operaatio oli annettu väärin, niin tulosta virheilmoitus. Nollalla jakoa ei saa ohjelmassa tapahtua!
*/