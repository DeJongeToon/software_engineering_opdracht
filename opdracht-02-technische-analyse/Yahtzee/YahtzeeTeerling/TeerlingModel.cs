using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {
        // Onthoudt het aantal ogen van de teerling
        private int _aantalOgen;
        private bool isKleur;
        private Random randomNr;
        private bool toonWerp = true;

        public TeerlingModel()
        {
            // standaardwaarden instellen
            isKleur = false;
            _aantalOgen = 0;

            // instantie 
            if (randomNr == null)
            {
                randomNr = new Random();
            }
        }

        public void Werp() // willekeurig getal tussen 1 en 7
        {
            _aantalOgen = randomNr.Next(1, 7);
        }

        public void toggleKleur()  // functie om waarde om te draaien
        {
            isKleur = !isKleur;
        }

        // Getters en setters
        public int AantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }

        public bool Gekleurd
        {
            get
            {
                return isKleur;
            }
            set {

                isKleur = value;

            }
        }
        public int Aantalogen //mogelijk maken dat andere aantal ogen teerling aanpassen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }
        public bool ToonWerp
        {
            get
            {
                return toonWerp;
            }
            set
            {
                toonWerp = value;
            }
        }



    }
}
