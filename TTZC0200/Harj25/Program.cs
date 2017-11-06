/*
 *  Muuta harjoitusta 22 niin, etta valikko nayttaa seuraavalta:
 *  
 *  VALIKKO
 *  0 Lopeta
 *  1 Lisaa henkilo
 *  2 Nayta henkilo
 *  3 Nayta kaikki henkilot
 *  4 Poista henkilon tiedot
 *  5 Tallenna tiedot tiedostoon
 *  6 Hae tiedot tiedostosta
 *  
 *  
 *  ja toteuta valikossa näkyvät toiminnot.
 *  
 *  Valitse haluamasi tallennusformaatti.
 * 
 * ---------------------------------------------------------------
 * 
 *  Muuta harjoituksen 24 toiminnallisuutta niin, etta
 *  varaat henkilötiedoille tilan dynaamisesti (max 10 hlo).
 *  Muuta valikko alla olevan esimerkin mukaiseksi ja toteuta valikossa
 *  näkyvät toiminnot.
 *  
 *  VALIKKO
 *  0 Lopeta
 *  1 Lisaa henkilo
 *  2 Nayta henkilo
 *  3 Nayta kaikki henkilot
 *  4 Poista henkilon tiedot
 */

using System;

namespace Harj25
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int valinta = Ali.Valikko();
                if (valinta != -1)
                    try
                    {
                        Ali.KasitteleValinta(valinta);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message + "\n");
                    }
                else
                    continue;
            }
        }
    }
}
