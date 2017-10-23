/*
 *  Tee ohjelma, joka kysyy henkilotietosi ja tallentaa ne tietueeseen.
 *  Tietueeseen talletetaan seuraavat tiedot:
 *  etunimi (merkkijono; C:n merkkitaulukko)
 *  sukunimi (merkkijono; C:n merkkitaulukko)
 *  koulumatka (reaaliluku)
 *  osoite (merkkijono; C:n merkkitaulukko)
 *  postinumero (merkkijono; C:n merkkitaulukko)
 *  kengannumero (kokonaisluku)
 *  
 *  Ohjelma tulostaa lopuksi tietueen tiedot naytölle.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj16
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
