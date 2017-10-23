/*
 *  Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua.
 *  
 *  Ohjelma tulostaa tekstin BINGO, mikäli luvut ovat samoja.
 *  
 *  Muussa tapauksessa ohjelma tulostaa tekstin BONGO.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku");
            int luku1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna toinen luku");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            if (luku1 == luku2)
            {
                Console.WriteLine("BINGO");
            }
            else
            {
                Console.WriteLine("BONGO");
            }
        }
    }
}
