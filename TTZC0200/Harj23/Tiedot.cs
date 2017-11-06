namespace Harj23
{
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
