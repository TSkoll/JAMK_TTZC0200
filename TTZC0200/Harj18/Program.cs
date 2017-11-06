/*
 *  Tee ohjelma, joka kysyy viiden koiran nimet ja iät.
 *  Tiedot tallennetaan tietuetaulukkoon.
 *  a) järjestä tiedot ikä -kentän mukaan suuruusjärjestykseen
 *  (pienimmästä suurimpaan). Ohjelma tulostaa lopuksi
 *  jarjestetyn taulukon näytälle.
 *  b) järjestä tiedot nimi -kentän mukaan aakkosjärjestyksessä
 *  Ohjelma tulostaa lopuksi jarjestetyn taulukon näytolle.
 *  
 *  Lajittelu tulee toteuttaa siten, että se toimisi samoin
 *  myäs 50 tai 5000 koiran tapauksssa.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj18
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira[] Koirat = new Koira[5];
            for (var i = 0; i < Koirat.Length; i++)
            {
                Console.WriteLine("Anna koiran nimi");
                string nimi = Console.ReadLine();

                Console.WriteLine("Anna koiran ikä");
                int ika = Convert.ToInt32(Console.ReadLine());

                Koirat[i] = new Koira() { Nimi = nimi, Ika = ika };
            }

            var palautus = Koirat.OrderBy(x => x.Nimi);
            foreach (var k in palautus)
            {
                Console.WriteLine($"{k.Nimi} | {k.Ika}");
            }
            Console.ReadKey();
        }
    }

    public class Koira
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
}
