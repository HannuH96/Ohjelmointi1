using System;

namespace VKO_36_KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frstname, lstname, brthyear;

            //Kysytään käyttäjältä tietoja
            Console.WriteLine("Please write your first name : ");
            frstname = Console.ReadLine();
            Console.WriteLine("Please write your last name : ");
            lstname = Console.ReadLine();
            Console.WriteLine("Please enter the year of your birth : ");
            brthyear = Console.ReadLine();

            //Tulostetaan
            Console.WriteLine("Student {0} {1}, you were born on the year {2}.", frstname, lstname, brthyear);
        }
    }
}

/* 
 Esittele muuttujat etunimi, sukunimi ja syntymavuosi (kaikki string tyyppisiä!). -tehty
 Lue muuttujiin käyttäjältä arvot. -tehty
 Tulosta sen jälkeen seuraavasti muuttujien avulla: -tehty

Opiskelija Sami Lahti, olet syntynyt vuonna 1971.

    - Hannu H
*/ 