/*
 *  Muunna harjoitus 11 niin, etta käytät seuraavia aliohjelmia:
 *  
 *  int KysyValinta(void);
 *  
 *  -> KysyValinta paluttaa käyttäjän antaman valintanumeron (0-6)
 *  
 *  double Summa(float luku1, int luku2);
 *  
 *  -> Summa laskee yhteen annetut tiedot ja palauttaa summan pääohjelmaan
 */

using System;
using System.Threading;

namespace Harj21
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                // Kysy luvut
                (int, int)? Luvut = KysyLuvut();
                if (Luvut != null)
                {
                    int Valinta = KysyValinta();

                    if (Valinta == -1)
                    {
                        Console.WriteLine("Valintasi ei näyttänyt olevan luku! Kokeillaanpa uudestaan...");

                        Thread.Sleep(2500);
                        continue;
                    }

                    try
                    {
                        double lopputulos = KasitteleValinta(Valinta, Luvut.Value);
                        NaytaLopputulos(lopputulos);

                        continue;
                    }
                    catch (OperationCanceledException)
                    {
                        continue;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.Clear();
                        Console.WriteLine("Ei voida jakaa nollalla!");

                        Thread.Sleep(2500);

                        continue;
                    }
                    catch (NotImplementedException)
                    {
                        Console.Clear();
                        Console.WriteLine("Valinta ei kelpaa! Valitse valinta lukujen 0-6 väliltä!");

                        Thread.Sleep(2500);

                        continue;
                    }
                }
                else
                    continue;
            }
        }

        public static (int, int)? KysyLuvut()
        {
            Console.Clear();
            Console.WriteLine("Anna ensimmäinen arvo");
            if (int.TryParse(Console.ReadLine(), out int val1))
            {
                Console.Clear();
                Console.WriteLine($"Anna toinen arvo, ensimmäinen arvo on: {val1}");
                if (int.TryParse(Console.ReadLine(), out int val2))
                    return (val1, val2);
                else
                    return null;
            }
            else
                return null;
        }

        public static int KysyValinta()
        {
            Console.Clear();
            Console.WriteLine("Mikä laskutoimitus? Syötä pelkkä luku.\n0. Lopetus\n1. Summa\n2. Erotus\n3. Tulo\n4. Osamäärä\n5. Jakojäännös\n6. Syötä uudet luvut.");

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int val))
                return val;
            else
                return -1; // Error
        }

        public static double KasitteleValinta(int valinta, (int, int) Arvot)
        {
            int luku1 = Arvot.Item1;
            int luku2 = Arvot.Item2;

            switch (valinta)
            {
                case 0:
                    Environment.Exit(0);
                    return 0;
                case 1:
                    return Summa(luku1, luku2);
                case 2:
                    return Erotus(luku1, luku2);
                case 3:
                    return Tulo(luku1, luku2);
                case 4:
                    if (luku2 != 0)
                        return Osamaara(luku1, luku2);
                    else
                        throw new DivideByZeroException();
                case 5:
                    return Jakojaannos(luku1, luku2);
                case 6:
                    throw new OperationCanceledException();
                default:
                    throw new NotImplementedException("Valinta ei kelpaa!");
            }
        }

        public static void NaytaLopputulos(double lopputulos)
        {
            Console.Clear();
            Console.WriteLine($"Lopputulos: {lopputulos}");

            Thread.Sleep(2500);
            return;
        }

        // Laskutoimitukset
        public static double Summa(int luku1, int luku2)
        {
            return luku1 + luku2;
        }

        public static double Erotus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }

        public static double Tulo(int luku1, int luku2)
        {
            return luku1 * luku2;
        }

        public static double Osamaara(int luku1, int luku2)
        {
            // Muunnetaan kokonaisluvut tuplatarkkuisiksi liukuluvuiksi että tulokseksi saadaan sama
            return (double)luku1 / (double)luku2;
        }

        public static double Jakojaannos(int luku1, int luku2)
        {
            return luku1 % luku2;
        }
    }
}
