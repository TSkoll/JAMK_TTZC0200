/*
 *  Kirjoita ohjelma, joka kysyy käyttäjältä lompakossa olevan rahamäärän
 *  ja lihapiirakan hinnan.
 *  
 *  Ohjelma tutkii, onko käyttäjällä varaa ostaa lihapiirakka
 *  Jos on, ohjelma ilmoittaa, kuinka paljon lompakkoon jää vielä rahaa.
 *  Muuten ohjelma kehottaa käyttäjää paastoamaan.
 *  
 *  Käytä vain kahta muuttujaa. älä vähennä lompakon sisältää, ellet voi
 *  ostaa lihapiirakkaa.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna rahamäärä");
            float RahaMaara = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Anna lihapiirakan hinta");
            float LihisHinta = Convert.ToSingle(Console.ReadLine());

            if (RahaMaara >= LihisHinta)
            {
                Console.WriteLine($"Hip hip hurraa!\nSinulla on varaa lihapiirakkaan!\nPiirakan oston jälkeen sinulla on jäljellä vielä {RahaMaara - LihisHinta}");
            }
            else
            {
                Console.WriteLine($"No höh, nyt pitää mennä paastolinjalla.\nLihapiirakkaan oisi tarvittu vielä ${LihisHinta - RahaMaara} lisää");
            }
        }
    }
}
