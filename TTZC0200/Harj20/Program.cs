/*
 *  Kuten harjoitus 19, mutta toteuta kayttaen taulukkoa ja osoitinta
 *  tiedon käsittelyyn
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Aikaisemmin tehty
namespace Harj20
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Nopeustaulukko
            int[] Nopeudet = { 0, 0, 0, 0, 0 };

            // Kysymyskerta
            int Kerta = 0;

            while (true)
            {
                // Kysytään nopeus
                Console.WriteLine($"[{String.Join(",", Nopeudet)}] Keskinopeus: {Nopeudet.Keskinopeus()}\nAnna luku, negatiivinen luku lopettaa ohjelman.");

                int nopeus;
                try
                {
                    nopeus = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Syöte ei ole luku!");
                    continue;
                }

                // Jos luku on negatiivinen, lopetetaan.
                if (nopeus < 0)
                    break;

                // Asetetaan nopeus nopeustaulukkoon
                Nopeudet[Kerta % Nopeudet.Length] = nopeus;

                Kerta++;
            }
        }
    }

    public static class Jatkeet
    {
        /// <summary>
        /// Laskee keskinopeuden syötetystä kokonaislukutaulukosta.
        /// </summary>
        /// <param name="nopeudet">System.Int32[], nopeudet, josta keskinopeus lasketaan.</param>
        /// <returns>System.Double, laskettu keskinopeus.</returns>
        public static double Keskinopeus(this int[] nopeudet)
        {
            int summa = 0;
            foreach (int nopeus in nopeudet)
                summa += nopeus;

            return (double)summa / nopeudet.Length;
        }
    }
}
