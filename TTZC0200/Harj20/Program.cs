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
    class Program
    {
        // Lista nopeuksista
        internal static List<int> Speeds = new List<int>();

        // Keskinopeus
        internal static int AverageSpeed = 0;

        static void Main(string[] args)
        {
            // Asetetaan alkuarvot
            Speeds.AddRange(new int[] { 0, 0, 0, 0, 0 });

            while (true)
            {
                // Tyhjennetään konsoli
                Console.Clear();

                // Tulostetaan arvot ja ohje
                Console.WriteLine($"Nopeudet: [{string.Join(", ", (Speeds as IEnumerable<int>).Reverse())}], keskinopeus: {AverageSpeed} km/h\n" +
                    "Anna uusi arvo, negatiiviset arvot sulkevat ohjelman.");

                // Odotetaan käyttäjän antamaa arvoa ja tallenetaan se muistiin
                var input = Console.ReadLine();

                // Testataan että arvo on numero
                if (Int32.TryParse(input, out int value))
                {
                    // Arvo numero, käsittele
                    if (value >= 0)
                    {
                        // Lisää arvo nopeuksiin
                        Speeds.Add(value);

                        // Siirrä arvot
                        Speeds = HopValues(Speeds);

                        // Lasketaan keskinopeus
                        AverageSpeed = AvgSpeed();

                        // Jatka kierrosta
                        continue;
                    }
                    else
                    {
                        // Arvo alle 0, poistu ohjelmasta koodilla 0 (ei virhettä)
                        Environment.Exit(0);
                    }
                }
                else
                {
                    // Arvo ei numero, anna palaute
                    Console.Clear();

                    // Kerro virhe
                    Console.WriteLine("Arvo ei ole numero tai on liian iso/pieni");

                    // Odota 5 sekunttia
                    Task.Delay(5000);

                    // Jatka kierrosta
                    continue;
                }
            }
        }

        private static int AvgSpeed()
        {
            // Laske keskiarvo ja palauta pyöristetty arvo
            return Convert.ToInt32(Math.Round(Speeds.Average(), 0, MidpointRounding.ToEven));
        }

        private static List<int> HopValues(List<int> SourceValues)
        {
            // Luodaan palautuslista
            var retList = new List<int>();

            // Kopioidaan lista palautusmuuttujaan ja pudotetaan ensimmäinen arvo pois
            for (var i = 0; i < SourceValues.Count - 1; i++)
                retList.Add(SourceValues[i + 1]);

            // Palautetaan uudet arvot
            return retList;
        }
    }
}
