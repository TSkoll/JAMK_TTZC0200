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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj19
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
