using System;

namespace VKO_38_K3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int k;

            for(i = 11, k = 10 ; i <= 20  ; i++, k-- ) // Jatketaan niin kauan kunnes i = 20, joka kierros lisätään/vähennetään muuttujista...
            {
                Console.WriteLine("{0} {1}", i, k);
            }

        }
    }
}

/*
 Esittele kaksi laskurimuuttujaa ja tulosta niiden avulla for-silmukassa:


 11   10
12    9
13    8
...
19    2
20    1
     
     */
