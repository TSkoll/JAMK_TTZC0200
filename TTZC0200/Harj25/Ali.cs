using Harj25.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Harj25
{
    public static class Ali
    {
        static Tiedot[] HenkiloTiedot = new Tiedot[10];
#region Valikko
        /*
         *  Käyttäjän valikon syötteen numeraalisuuden testaus 
         */
        public static int Valikko()
        {
            Console.WriteLine("0. Lopeta\n1. Lisää Henkilö\n2. Näytä henkilö\n3. Näytä kaikki henkilöt\n4. Poista henkilön tiedot\n5. Tallenna tiedot tiedostoon\n6. Hae tiedot tiedostosta");
            if (int.TryParse(Console.ReadLine(), out int valinta))
                return valinta;
            else
                return -1; // Error
        }

        /*
         *  Valikon toiminnallisuus
         */
        public static void KasitteleValinta(int valinta)
        {
            Console.Clear();
            switch (valinta)
            {
                case 0:
                    Environment.Exit(0);
                    return;
                case 1:
                    KasitteleHenkilonLisays();
                    return;
                case 2:
                    KasitteleHenkilonTulostus(HenkiloTiedot);
                    return;
                case 3:
                    TulostaKaikkiHenkilot(HenkiloTiedot);
                    return;
                case 4:
                    KasitteleHenkilonPoisto(HenkiloTiedot);
                    return;
                case 5:
                    TiedostonHallinta.TallennaTiedot(HenkiloTiedot);
                    return;
                case 6:
                    HenkiloTiedot = TiedostonHallinta.LataaTiedot();
                    return;
                default:
                    throw new ArgumentException("Valinta ei kelpaa!");
            }
        }
#endregion

#region Henkilön tulostus
        /*
         *  Käsittelee käyttäjän syöttään yhden tiedon tulostamiseen
         */
        public static void KasitteleHenkilonTulostus(Tiedot[] tiedot)
        {
            Tiedot[] Vaihtoehdot = EtsiVaihtoehdot(tiedot);

            Console.Clear();
            if (Vaihtoehdot.Length != 0)
            {
                Console.WriteLine($"Valitse tulostettava henkilö, mahdolliset vaihtoehdot: 1-{Vaihtoehdot.Length}");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    if (value <= Vaihtoehdot.Length)
                    {
                        TulostaHenkilo(Vaihtoehdot[value - 1]);
                    }
                    else
                        throw new ArgumentException("Vaihtoehto ei kelpaa!");
                }
                else
                    throw new ArgumentException("Vaihtoehdon pitää olla luku!");
            }
            else
                throw new ArgumentException("Ei näytettäviä vaihtoehtoja!");
        }

        /*
         *  Yhden henkilön tulostus
         */
        public static void TulostaHenkilo(Tiedot tiedot)
        {
            Console.WriteLine($"Nimi: {tiedot.Nimi}\nKoulumatka: {tiedot.Koulumatka}\nHatun koko: {tiedot.Hatun_Koko}\n");
        }

        /*
         *  Kaikkien henkilöiden tulostus
         */
        public static void TulostaKaikkiHenkilot(Tiedot[] tiedot)
        {
            string palaute = "Sijainti - Nimi | Koulumatka | Hatun koko\n";
            for (int i = 0; i < tiedot.Length; i++)
            {
                Tiedot henkilo = tiedot[i];
                if (henkilo == null) continue;

                palaute += $"{i + 1} - {henkilo.Nimi} | {henkilo.Koulumatka} | {henkilo.Hatun_Koko}\n";
            }
            Console.WriteLine(palaute);
        }
#endregion

#region Henkilön lisäys ja poisto
        /*
         *  Henkilön lisäykseen liittyvä käyttäjän syötteen käsittely
         */
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

        /*
         *  Yhden henkilön lisäys sisäiseen muistiin
         */
        public static void LisaaHenkilo(Tiedot tiedot, int sij)
        {
            if (sij >= 0 && sij <= 9)
            {
                HenkiloTiedot[sij] = tiedot;
                Console.WriteLine($"Henkilö {tiedot.Nimi} sijoitettu sijaintiin {sij + 1}!\n");
            }
            else
                throw new ArgumentException("Sijainti saa olla vain väliltä 1-10!");
        }

        /*
         *  Henkilön poistoon liittyvä käyttäjän syötteen käsittely
         */
        public static void KasitteleHenkilonPoisto(Tiedot[] tiedot)
        {
            Tiedot[] Vaihtoehdot = EtsiVaihtoehdot(tiedot);
            string vaihtoehtoTeksti = "";
            for (var i = 0; i < Vaihtoehdot.Length; i++)
            {
                vaihtoehtoTeksti += $"{i + 1} - {Vaihtoehdot[i].Nimi}\n";
            }

            Console.Clear();
            if (Vaihtoehdot.Length != 0)
            {
                Console.WriteLine(("Valitse poistettava henkilö, mahdolliset vaihtoehdot:\n" + vaihtoehtoTeksti).Trim());
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    if (value <= Vaihtoehdot.Length)
                    {
                        PoistaHenkilo(Vaihtoehdot[value - 1]);
                    }
                    else
                        throw new ArgumentException("Vaihtoehto ei kelpaa!");
                }
                else
                    throw new ArgumentException("Vaihtoehdon pitää olla luku!");
            }
            else
                throw new ArgumentException("Ei näytettäviä vaihtoehtoja!");
        }

        /*
         *  Yhden henkilön poisto muistista
         */
        public static void PoistaHenkilo(Tiedot poistettava)
        {
            HenkiloTiedot[Array.IndexOf(HenkiloTiedot, poistettava)] = null;
            Console.WriteLine($"Henkilö {poistettava.Nimi} poistettu!\n");
        }
#endregion

#region Muut
        /// <summary>
        /// Etsii kelvot vaihtoehdot (ei-tyhjät merkinnät) taulukosta ja palauttaa vain kelvot vaihtoehdot.
        /// </summary>
        /// <param name="tiedot">Taulukko, joka sisältää sekä epäkelvot että kelvolliset vaihtoehdot</param>
        /// <returns>Harjoitus24.Tiedot, Kelvot ei-tyhjät henkilötiedot</returns>
        public static Tiedot[] EtsiVaihtoehdot(Tiedot[] tiedot)
        {
            IEnumerable<Tiedot> vaihtoehdot = tiedot.Where(x => x != null);
            return vaihtoehdot.ToArray();
        }
#endregion
    }
}
