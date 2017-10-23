/*
 *  Tee ohjelma, joka kysyy käyttäjältä nimen, pituuden sentteinä ja painon kiloina.
 *  Ohjelma laskee ja tulostaa käyttäjän ihannepainon (pituus-100). Lisäksi
 *  ohjelma kertoo käyttäjän nykyisen painon eron kiloina verrattuna ihanne-
 *  painoon. Ohjelman käyttöliittymä toimii seuraavasti:
 *  
 *  Ihannepaino
 *  
 *  Ohjelma laskee ihannepainosi
 *  pituutesi perusteella.
 *  
 *  Anna nimesi > Mooses
 *  Anna pituutesi sentteinä > 175
 *  Anna osoitteesi > Peikkovuori 5 as 4
 *  Anna painosi kiloina > 89
 *  
 *  
 *  Arvoisa Mooses
 *  Osoitteesi on Peikkovuori 5 as 4
 *  Nykyinen painosi 89.0 kg
 *  Ihannepainosi 75.0 kg
 *  Erotus 14.0 kg
 *  
 *  
 *  Käytä cin/cout/cin.get... olioita ohjelman
 *  toteuttamiseen (c++ metodit, kirja sivu 92 - 99)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi, osoite;
            int pituus;
            float paino;

            Console.WriteLine("Anna nimesi");
            nimi = Console.ReadLine();

            Console.WriteLine("Anna pituutesi sentteinä");
            pituus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna osoitteesi");
            osoite = Console.ReadLine();

            Console.WriteLine("Anna painosi");
            paino = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Arvoisa {nimi}\nOsoitteesi on {osoite}\nNykyinen painosi on {paino}\nIhannepainosi on {pituus - 100f}\nErotus {(pituus - 100f) - paino}");
        }
    }
}
