/*
 *  Muokkaa edellistä ohjelmaa siten, että edellä määriteltyä tietuetyyppiä
 *  käytetään myäs kahden muun "koululaisen" tietojen tallentamiseen.
 *  Näiden kahden muun koululaisen tiedot alustetaan ao. muuttujien
 *  määrittelyn yhteydessä. Ainoastaan yhden koululaisen tiedot kysytään
 *  käyttäjältä edellisen tehtävän tapaan.
 *  
 *  Tulosta kolmen koululaisen tiedot koulumatkan mukaisessa
 *  suuruusjärjestyksessä (pienimmästä suurimpaan) näytälle
 */

using System;
using System.Linq;

namespace Harj17
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiedot henk = new Tiedot();
            Tiedot henk2 = new Tiedot()
            {
                Nimi = "Martti",
                SNimi = "Ahtisaari",
                KNum = 44,
                KMatka = 4f,
                Osoite = "Hellureitie 40",
                PNum = "43050"
            };

            Tiedot henk3 = new Tiedot()
            {
                Nimi = "Heikki",
                SNimi = "Leppänen",
                KNum = 56,
                KMatka = 7.6f,
                Osoite = "Leegokuja 3",
                PNum = "79420"
            };

            Console.WriteLine("Anna etunimesi");
            henk.Nimi = Console.ReadLine();

            Console.WriteLine("Anna kengännumerosi");
            henk.KNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna sukunimesi");
            henk.SNimi = Console.ReadLine();

            Console.WriteLine("Anna koulumatkasi pituus");
            henk.KMatka = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Anna osoitteesi");
            henk.Osoite = Console.ReadLine();

            Console.WriteLine("Anna postinumerosi");
            henk.PNum = Console.ReadLine();

            Console.WriteLine($"\n{henk.Nimi} {henk.SNimi}\n{henk.Osoite}\n{henk.PNum}\n{henk.KNum} {henk.KMatka}");
            Console.Clear();

            // En jaksanut alkaa kirjoittamaan järjestelyalgoritmiä
            Tiedot[] Henkilot = new Tiedot[] { henk, henk2, henk3 }.OrderBy(x => x.KMatka).ToArray();
            
            foreach (var h in Henkilot)
            {
                Console.WriteLine($"{h.Nimi} {h.SNimi} | {h.Osoite} | {h.PNum} | {h.KNum} | {h.KMatka}");
            }
            Console.ReadKey();
        }
    }
    public struct Tiedot
    {
        public string Nimi { get; set; }
        public int KNum { get; set; }
        public string SNimi { get; set; }
        public float KMatka { get; set; }
        public string Osoite { get; set; }
        public string PNum { get; set; }
    }
}
