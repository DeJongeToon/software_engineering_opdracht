using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    // Vergeet niet de controller op public te zetten
    // Zo kan de view die de controller als argument meekrijgt aan de properties
    public class TeerlingController
    {
        static int seeder = 0; //voor het getal niet altijd hetzelfde te laten 
        Random random = new Random(++seeder); //random getal genereren

        // Member die de view opvangt
        TeerlingView _view;

        // Member die het model opvangt
        // Maak public zodat de view hier ook aan kan
        public TeerlingModel _model;
        private AllController _controllerAll;
        

        public TeerlingController(AllController controllr )
        {
            // Maak een instantie van de view
            // Geef een de huidige instantie (= controller = this) mee als argument
            _view = new TeerlingView( this );

            // Maak een nieuwe instantie van het model aan
            _model = new TeerlingModel();
            _controllerAll = controllr;

        }

        // Return de huidige view
        public TeerlingView getView()
        {
            return _view;
        }

        // Methode die een willekeurige waarde voor teerling berekent
        // en deze toevoegt aan de database (=model)
        public void werpTeerling()
        {
            AllModel _modelYahtzee = _controllerAll.getModel();
            if (!_model.Gekleurd && _modelYahtzee.AantalWorpen <= _modelYahtzee.MaxAantalWorpen)
            {
                int teerlingGetal = random.Next(1, 7); //random tussen 1 en 6
                _model.Aantalogen = teerlingGetal; //random getal doorsturen naar model
            }
        }

        public void Werp()
        {
            // is de teerling vast?
            if (!_model.Gekleurd)
            {
                // random werp uitvoeren in model
                _model.Werp();

                // view update
                _view.updateUI();
            }
        }
        public void resetTeerling()
        {
            _model.Aantalogen = 0;
            _model.Gekleurd = false;
            _view.updateViewTeerling();
        }

        public void toggleKleur()
        {
            //model update
            _model.toggleKleur();

            // view update
            _view.updateUI();
        }

        // Return de waarden
        public bool Vast
        {
            get
            {
                return _model.Gekleurd;
            }
        }
        public int AantalOgen
        {
            get
            {
                return _model.AantalOgen;
            }
        }
    }
}
