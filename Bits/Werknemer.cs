namespace Bits
{
    public class Werknemer
    {
        /// <summary>
        /// de code van de werknemer
        /// </summary>
        public string ID
        {
            get; set;
        }

        /// <summary>
        /// de volledige naam van de werknemer
        /// </summary>
        public string Naam
        {
            get; set;
        }

        /// <summary>
        /// Het adres van de werknemer
        /// </summary>
        public string Adres
        {
            get; set;
        }

        /// <summary>
        /// Het geslacht van de werknemer
        /// </summary>
        public string Geslacht
        {
            get; set;
        }

        /// <summary>
        /// de geboortedatum
        /// </summary>
        public System.DateTime Geboortedatum
        {
            get; set;
        }

        /// <summary>
        /// de leeftijd
        /// </summary>
        public byte Leeftijd
        {
            get; set;
        }

        public System.Collections.Generic.List<string> Rollen()
        {
            throw new System.NotImplementedException();
        }

        public string Tostring()
        {
            throw new System.NotImplementedException();
        }
    }
}