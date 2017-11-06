using System;

namespace Harj23
{
    public static class Ali
    {
        static Tiedot[] HenkiloTiedot = new Tiedot[10];
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
}