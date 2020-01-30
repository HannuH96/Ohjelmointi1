using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VKO_41_KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hakemisto = "C:\\temp";
            string[] hkm = new string[10];
            int i, numero;

            for (i = 0; i < 10; i++) //Luo C:\temp hakemiston alle for-silmukassa hakemistot: hakemisto1-hakemisto10
            {
                numero = i + 1;
                Directory.CreateDirectory(hakemisto + "\\hakemisto" + numero);
            }

            hkm =  Directory.GetDirectories(hakemisto); //sen jälkeen hae string-taulukkoon kaikki c:\temp:ssä olevat hakemistot 

            for (i = 0; i < 10; i++) //ja jossakin silmukassa tuhoa ne
            {
                numero = i + 1;
                Directory.Delete(hakemisto + "\\hakemisto" + numero);
            }


        }
    }
}



/*
Luo C:\temp hakemiston alle for-silmukassa hakemistot - jep

hakemisto1
hakemisto2
....
hakemisto10

sen jälkeen hae string-taulukkoon kaikki c:\temp:ssä olevat hakemistot - jep
ja jossakin silmukassa tuhoa ne - jep

 */
