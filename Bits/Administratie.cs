using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bits
{
    public class Administratie
    {
        public List<Klant> Klanten
        {
            get; set;
        }

        public List<Werknemer> Werknemers
        {
            get; set;
        }

        /// <summary>
        /// Voeg een klant toe aan de lijst
        /// </summary>
        /// <param name="Klanttoevoeg">de naam voor het toevoegen van klanten</param>
        public string AddKlant()
        {
            List<string> Klant = new List<string>();
            Klant.Add("");
            return AddKlant();
        }
        /// <summary>
        /// hier worden de gegevens van de klant aangepast moet treu geven als lukt anders false
        /// </summary>
        public bool Editklant()
        {

            List<string> Klant = new List<string>();
            return Editklant();
        }
        /// <summary>
        /// hier word de klant verwijdert
        /// </summary>
        public bool Deleteklant()
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

            return Deleteklant();
        }
        /// <summary>
        /// klant opzoeken in lijst
        /// </summary>
        public Klant Getklant()
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
            return Getklant();
        }

        /// <summary>
        /// voeg werknemer toe
        /// </summary>
        public void AddWerknemer()
        {

            List<string> Werknemer = new List<string>();
            
           
        }

        /// <summary>
        /// pas de gegevens aan
        /// </summary>
        public bool EditWerknemer()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// verwijder de werknemer
        /// </summary>
        public bool Deletewerknemer()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// zoek een werknemer
        /// </summary>
        public Werknemer GetWerknemer()
        {
            throw new System.NotImplementedException();
        }
    }
}