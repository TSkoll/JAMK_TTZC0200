/*
 *  Tee ohjelma, joka toimii henkilörekisterinä (max 10).
 *  Ohjelma antaa käyttäjälle seuraavan valikon:
 *  
 *  VALIKKO
 *  0 Lopeta
 *  1 Lisaa henkilo
 *  2 Nayta kaikki henkilot
 *  
 *  Tallenna henkilöiden tiedot tietuetaulukkoon.
 *  Tallennettavia tietoja ovat
 *  etunimi (merkkijono)
 *  koulumatka (liukuluku)
 *  hatun koko (kokonaisluku)
 *  
 *  Toteuta ensin koko ohjelma pääohjelmana. 
 *  
 *  Tämän jälkeen lisää seuraavat aliohjelmat:
 *  a) int Valikko(void);
 *  
 *  b) void TulostaHenkilo(TIEDOT );
 *  c) void TulostaKaikkiHenkilot(TIEDOT [], int lkm);
 *  d) void LisaaHenkilo(TIEDOT [], int *lkm);
 */

using System;
using System.Threading;

namespace Harj22
{
    class Program
    {
        static Tiedot[] HenkiloTiedot = new Tiedot[10];
        static void Main(string[] args)
        {
            while (true)
            {
                int valinta = Valikko();
                if (valinta != -1)
                    try
                    {
                        KasitteleValinta(valinta);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                else
                    continue;
            }
        }

        public static int Valikko()
        {
            Console.WriteLine("0. Lopeta\n1. Lisää Henkilö\n2. Näytä kaikki henkilöt");
            if (int.TryParse(Console.ReadLine(), out int valinta))
                return valinta;
            else
                return -1; // Error
        }

        public static void KasitteleValinta(int valinta)
        {
            switch (valinta)
            {
                case 0:
                    Environment.Exit(0);
                    return;
                case 1:
                    KasitteleHenkilonLisays();
                    return;
                case 2:
                    TulostaKaikkiHenkilot(HenkiloTiedot);
                    return;
            }
        }

        // ??
        public static void TulostaHenkilo(Tiedot tiedot)
        {
            Console.WriteLine($"{tiedot.Nimi} | {tiedot.Koulumatka} | {tiedot.Hatun_Koko}");
        }

        public static void TulostaKaikkiHenkilot(Tiedot[] tiedot)
        {
            string palaute = "Sijainti - Nimi | Koulumatka | Hatun koko\n";
            for (int i = 0; i < tiedot.Length; i++)
            {
                Tiedot henkilo = tiedot[i];
                if (henkilo == null) continue;

                palaute += $"{i + 1} - {henkilo.Nimi} | {henkilo.Koulumatka} | {henkilo.Hatun_Koko}\n";
            }
            Console.Write(palaute);
        }

        public static void KasitteleHenkilonLisays()
        {
            Console.WriteLine("Anna tiedot muodossa \"(sijainti 1-10) (etunimi) (koulumatka) (hatun koko)\"");
            string[] tiedot = Console.ReadLine().Split();
            if (tiedot.Length < 4)
                throw new ArgumentException("Ei tarpeeksi argumentteja!");

            if (int.TryParse(tiedot[0], out int sij))
            {
                if (float.TryParse(tiedot[2], out float matka))
                {
                    if (int.TryParse(tiedot[3], out int hatunKoko))
                    {
                        Tiedot lisattava = new Tiedot(tiedot[1], matka, hatunKoko);
                        LisaaHenkilo(lisattava, sij - 1);
                    }
                    else
                        throw new ArgumentException("Hatun koko ei kelpaa!");
                }
                else
                    throw new ArgumentException("Koulumatka ei kelpaa!");
            }
            else
                throw new ArgumentException("Sijainti ei kelpaa!");
        }

        public static void LisaaHenkilo(Tiedot tiedot, int sij)
        {
            if (sij >= 0 && sij <= 9)
                HenkiloTiedot[sij] = tiedot;
            else
                throw new ArgumentException("Sijainti saa olla vain väliltä 1-10!");
        }
    }

    public class Tiedot
    {
        public string Nimi { get; set; }
        public float Koulumatka { get; set; }
        public int Hatun_Koko { get; set; }

        public Tiedot() { }
        public Tiedot(string Nimi, float Koulumatka, int Hatun_Koko)
        {
            this.Nimi = Nimi;
            this.Koulumatka = Koulumatka;
            this.Hatun_Koko = Hatun_Koko;
        }
    }
}
