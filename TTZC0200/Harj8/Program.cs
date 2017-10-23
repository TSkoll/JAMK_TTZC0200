/*
 *  Tee ohjelma, joka tulostaa annetut kolme lukua suuruus-
 *  järjestyksessä (pienimmästä suurimpaan) näytölle
 *  (katso harj. 1 suunnitelma)
 *  a) käytä kokonaislukuja
 *  b) käytä liukulukuja (=reaalilukuja)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme arvoa välilyönnillä erottaen ne.");
            string[] arvot = Console.ReadLine().Split(' ');

            float luku1 = Convert.ToSingle(arvot[0]);
            float luku2 = Convert.ToSingle(arvot[1]);
            float luku3 = Convert.ToSingle(arvot[2]);

            if (luku1 < luku2)
            {
                if (luku2 < luku3)
                {
                    Console.WriteLine($"{luku1} < {luku2} < {luku3}");
                }
                else
                {
                    Console.WriteLine($"{luku1} < {luku3} < {luku2}");
                }
            }
            else
            {
                if (luku1 < luku3)
                {
                    Console.WriteLine($"{luku2} < {luku1} < {luku3}");
                }
                else
                {
                    Console.WriteLine($"{luku2} < {luku3} < {luku1}");
                }
            }
        }
    }
}
