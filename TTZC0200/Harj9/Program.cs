/*
 *  Tee ohjelma, joka toimii laskimena.
 *  Käyttäjältä kysytään kaksi kokonaislukua,
 *  jonka jälkeen ohjelma antaa valikon
 *  laskutoimituksista. Valikko nayttaa
 *  seuraavalta:
 *  
 *  VALIKKO
 *  1. Summa
 *  2. Erotus
 *  3. Tulo
 *  4. Osamaara
 *  5. Jakojaannos
 *  
 *  Lopuksi ohjelma tulostaa valitun tuloksen naytölle.
 */

using System;

namespace Harj9
{
    class Program
    {
        static void Main(string[] args)
        {
            float lk1 = KysyLuku("Anna ensimmäinen luku");
            float lk2 = KysyLuku("Anna toinen luku");

            try
            {
                float tulos = Valikko(lk1, lk2);
                Console.WriteLine(tulos);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }

        static float Valikko(float lk1, float lk2)
        {
            byte valinta = Convert.ToByte(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    return lk1 + lk2;
                case 2:
                    return lk1 - lk2;
                case 3:
                    return lk1 * lk2;
                case 4:
                    if (lk2 == 0)
                        throw new ArgumentException("luku2 ei saa olla nolla!");
                    return lk1 / lk2;
                case 5:
                    return lk1 % lk2;
                default:
                    throw new ArgumentException("Ei käypä vaihtoehto!");
            }
        }

        static float KysyLuku(string teksti)
        {
            Console.WriteLine(teksti);
            return Convert.ToSingle(Console.ReadLine());
        }
    }
}
