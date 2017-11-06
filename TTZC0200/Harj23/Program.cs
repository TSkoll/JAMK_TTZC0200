/*
 *  Jaa aiemmin esitetty henkilörekisteri-ohjelma omiin "osa-projekteihin" ja
 *  otsikkotiedostoihin. Laita pääohjelma omaan tiedostoon (paa.cpp),
 *  aliohjelmat omaan tiedostoon (ali.cpp) ja
 *  määritelmät omaan otsikkotiedostoon (maarittely.h).
 *  
 *  Projekti tulee koostaa toimivaksi Visual Studio-
 *  ympäristösssä.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int valinta = Ali.Valikko();
                if (valinta != -1)
                    try
                    {
                        Ali.KasitteleValinta(valinta);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                else
                    continue;
            }
        }
    }
}
