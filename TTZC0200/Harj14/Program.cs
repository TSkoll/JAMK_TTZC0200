/*
 *  TäSSä TEHTÄVÄSSÄ ON KÄYTETTÄVÄ C-kielen merkkitaulukoita! Taulukon määrittely on siis muotoa 
 *  
 *  char mjono[xx];
 *  
 *  Tee ohjelma, joka kysyy käyttäjältä 17 merkkiä
 *  pitkän merkkijonon (ei välilyäntejä).
 *  a) Ohjelma tulostaa merkkijonon käänteisessä järjestyksessä näytälle
 *  (tulostus tyyppiä "cout << mjono1[4];" jne)
 *  b) Ohjelma kääntää annetun merkkijonon toiseen
 *  merkkijonoon ja tulostaa sen näytälle
 *  (tulostus tyyppiä "cout << mjono2;")
 *  c) merkkijono voi olla kuinka pitkä
 *  tahansa (max 100 kirjainta).
 *  Syätetyn merkkijonon pituutta ei saa
 *  laskea millään kirjastofunktiolla
 *  (esim. lenght tms.) Ohjelma
 *  tutkii onko annettu merkkijono
 *  palindromi ja ilmoittaa sen käyttäjälle.
 *  Välilyännit jonossa ovat sallittuja.
 *  
 *  Käyttäjä syöttää jonon: ABC_Kissa_kavelee
 *  ohjelma tulostaa: eelevak_assiK_CBA
 */

using System;

namespace Harj14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä ei tee mahdottomasti järkeä C#:lla mutta tehdään silti...
            Console.WriteLine("Anna syöte");
            string syote = Console.ReadLine();

            /*
             *  C#:ssa string (tai char[]) ei pääty \0 null-kirjaimeen.
             *  Microsoftin oman dokumentaation mukaan tämän sijaan kuuluisi käyttää string-tyypin (tai char[]) mukana tulee length-muuttujaa
             *  joka kertoo char-objektien määrän.
             *  
             *  Mahdollisuutena olisi käyttää StringInfo-oliota, mutta tämäkään ei paljasa null-kirjainta. Täten joudun käyttämään tehtävänannon vastaisesti string.length -muuttujaa
             *  koska parempaa vaihtoehtoa ei ole.
             *  
             *  Muita, mielestäni huonompia, vaihtoehtoja olisi esim. käyttää "foreach (char kirjain in syote)" -silmukkaa ja laskea manuaalisesti kirjainten määrän, mutta tämä ei
             *  olisi laskentatehollisista syistä hyvä ratkaisu.
             */

            string palaute = "";
            for (int i = 1; i <= syote.Length; i++)
            {
                palaute += syote[syote.Length - i];
            }
            Console.WriteLine($"Tuloste: {palaute}\nTuloste {((syote == palaute) ? "on" : "ei ole")} palindromi");
            Console.ReadKey();
        }
    }
}
