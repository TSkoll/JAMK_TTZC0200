/*
 *  Tee ohjelma, joka kysyy henkilötietosi seuraavasti:
 *  Anna (kaikki) etunimesi (merkkijono):
 *  Anna kengannumero (kokonaisluku):
 *  Anna sukunimi (merkkijono):
 *  Anna koulumatka (reaaliluku):
 *  Anna osoitteesi:
 *  Anna postinumero:
 *  
 *  Ohjelma tulostaa tiedot seuraavasti:
 *  sukunimi etunimet
 *  osoite
 *  postinumero
 *  kengannumero ja koulumatka
 *  
 *  Käytä C++:n cin- ja cout-olioita ohjelman toteuttamiseen.
 */

using System;

namespace Harj15
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiedot henk = new Tiedot();

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
