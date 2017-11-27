/*
 *  Tee ohjelma, joka toimii auton nopeusmittarina.
 *  Periaate on seuraava: Näppäimistä toimii
 *  nopeusanturina ja näyttä mittarin näyttänä.
 *  Nopeusmittari laskee viiden viimeisen nopeuden
 *  keskiarvon ja tulostaa sen nykyisenä nopeutena
 *  näytälle. Negatiivinen nopeus lopettaa ohjelman.
 *  Toiminta on siis seuraava:
 *  Ohjelman kaynnistyksessa mittari näyttää nolla
 *  0
 *  0
 *  0
 *  0
 *  0 (alkutila) nopeus = 0 km/h
 *  Anna nopeus: 10 
 *  => 2 km/h
 *  Anna nopeus: 20
 *  => 6 km/h
 *  Anna nopeus: 30
 *  => 12 km/h
 *  Anna nopeus: 40
 *  => 20 km/h
 *  Anna nopeus: 50
 *  => 30 km/h
 *  Anna nopeus: 50
 *  => 38 km/h
 *  Anna nopeus: 50
 *  => 44 km/h
 *  Anna nopeus: 50
 *  => 48 km/h
 *  Anna nopeus: 50
 *  => 50 km/h
 *  Anna nopeus: 50
 *  => 50 km/h
 *  Anna nopeus: -5
 *  => loppu
 *
 *  Käyttäjän syöte ohjelmalle lihavoitu ja kallistettu.
 *  Toteuta kayttaen taulukkoa.
 */

using System;

namespace Harj19
{
    class Program
    {
        // Antaa automaattisesti koon 5
        public static int[] Nopeudet = { 0, 0, 0, 0, 0 };

        // Käytetään nopeuksien asettamiseen
        public static int KysymysKerta = 0;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"Nopeudet: [{string.Join(", ", Nopeudet)}] | KA: {Nopeudet.Keskiarvo()}\nAnna luku, negatiivinen luku lopettaa ohjelman.");

                int syote = Convert.ToInt32(Console.ReadLine());

                // Sulje jos negatiivinen
                if (syote < 0)
                    break;

                // Aseta syote taulukkoon
                Nopeudet[KysymysKerta % 5] = syote;
                KysymysKerta++;
            }

            // Tulosta lopputuloste
            Console.Clear();
            Console.WriteLine($"Nopeudet: [{string.Join(", ", Nopeudet)}] | KA: {Nopeudet.Keskiarvo()}\nOhjelma loppuu napin painalluksen jälkeen.");
            Console.ReadKey();
        }
    }

    static class Jatko
    {
        /// <summary>
        /// Laskee keskiarvon annetusta taulukosta
        /// </summary>
        /// <param name="arvot">System.Int32[]. Taulukko arvoista.</param>
        /// <returns>System.Double. Keskiarvo.</returns>
        public static double Keskiarvo(this int[] arvot)
        {
            int summa = 0;
            foreach (int arvo in arvot)
                summa += arvo;

            return (double)summa / arvot.Length;
        }
    }
}
