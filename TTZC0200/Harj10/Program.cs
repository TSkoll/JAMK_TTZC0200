/*
 *  Tee ohjelma, joka laskee syötetyistä kokonaisluvuista sekä positiivisten
 *  että negatiivisten kokonaislukujen osuuden. Lukujen syöttä lopetetaan
 *  syöttämällä luku 0.
 *  
 *  Tulostus:
 *  Syötit kokonaislukuja seuraavasti:
 *  ----------------------------------
 *  Negatiiviset 7 kpl 70.00%
 *  Positiiviset 3 kpl 30.00%
 *  Yhteensä 10 kpl 100.00%
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj10
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiiviset = 0;
            int negatiiviset = 0;

            while (true)
            {
                Console.WriteLine("Anna kokonaisluku");
                int luku = Convert.ToInt32(Console.ReadLine());

                if (luku == 0) break;
                if (luku > 0)
                    positiiviset++;
                else
                    negatiiviset++;
            }

            Console.WriteLine($"Syötit kokonaislukuja seuuravasti:\n----------------------------------\nNegatiiviset {negatiiviset} kpl {((float)negatiiviset)/(positiiviset + negatiiviset) * 100}%\nPosiitiviset {positiiviset} kpl {((float)positiiviset) / (positiiviset + negatiiviset) * 100}%\nYhteensä: {positiiviset + negatiiviset} kpl {(((float)negatiiviset + positiiviset) / (negatiiviset + positiiviset)) * 100}%");
            Console.ReadKey(true);
        }
    }
}
