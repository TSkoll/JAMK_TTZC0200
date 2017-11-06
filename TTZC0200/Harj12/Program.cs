/*
 *  Tee ohjelma, joka kysyy käyttäjältä kokonaisluvun väliltä 1-9 ja
 *  tulostaa vastauksen perusteella seuraavan kuvion (jos vastaus on 6):
 *  
 *  1
 *  22
 *  333
 *  4444
 *  55555
 *  666666
 *  
 *  Jokainen numero tulee tulostaa toistorakenten avulla erikseen lauseella:
 *  cout << rivinro;
 */

using System;

namespace Harj12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna kokonaisluku väliltä 1-9");
            byte luku = Convert.ToByte(Console.ReadLine());

            for (byte i = 0; i <= luku; i++)
            {
                for (byte j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
