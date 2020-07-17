using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        /// <summary>
        /// hier worden de gegevens van de klant aangepast moet treu geven als lukt anders false
        /// </summary>
        public void Editklant()
        {
            List<string> Klant = new List<string>();
            
        }
        /// <summary>
        /// hier word de klant verwijdert
        /// </summary>
        public void Deleteklant()
        {
            List<string> Klant = new List<string>();
            bool kandit = false;
            if (kandit == false)
            {
                Klant.Remove("brooks koepka");
                kandit = true;
            }
            else
            {
                kandit = false;

            }
            
            
        }
        /// <summary>
        /// klant opzoeken in lijst
        /// </summary>
        public Guid Getklant() 
        {
            List<string> Klant = new List<string>();
            bool kandit = true;
            if (kandit == true)
            {
                Klant.Contains("Rory Mcilroy");
                kandit = true;
            }
            else
            {
                kandit = false;
                MessageBox.Show("Klant werd niet gevonden");
            }
        }
    }
}