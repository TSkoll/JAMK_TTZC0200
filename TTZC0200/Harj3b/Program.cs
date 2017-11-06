/*
 *  Muokkaa edellisestä ohjelmasta versio nimelle harj3b.cpp, jossa
 *  nimi ja osoite tulostetaan näytälle seuraavasti:
 *  
 *  **********************************
 *  * *
 *  * Etunimi *
 *  * Sukunimi *
 *  * *
 *  *-------------------------------------- *
 *  * *
 *  * Asemakatu 7 *
 *  * 40520 JKL *
 *  * *
 *  **********************************
 *
 */

using System;

namespace Harj3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna etunimesi");
            string etunimi = Console.ReadLine();

            Console.WriteLine("Anna sukunimesi");
            string sukunimi = Console.ReadLine();


            Console.WriteLine($"**********************************\n* *\n* {etunimi} *\n* {sukunimi} *\n* *\n* -------------------------------------- *\n* *\n* Asemakatu 7 *\n* 40520 JKL *");
        }
    }
}
