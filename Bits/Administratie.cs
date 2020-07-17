using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bits
{
    public class Administratie
    {
        /// <summary>
        /// Alle werknemers
        /// </summary>
        public List<string> Werknemers()
        {
            List<string> Werknemer = new List<string>();
            return Werknemer;
        }

        /// <summary>
        /// Alle klanten
        /// </summary>
        /// <param name="Klant"></param>
        public List<string> Klanten()
        {
            List<string> Klant = new List<string>();
            return Klant;

        }
        /// <summary>
        /// Voeg een klant toe aan de lijst
        /// </summary>
        /// <param name="Klanttoevoeg">de naam voor het toevoegen van klanten</param>
        public void AddKlant()
        {
            List<string> Klant = new List<string>();
            Klant.Add("");
        }
        
    }
}