using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class AllController
    {

        public AllModel _model;
        AllView _view;

        Random random_getal = new Random();

       

        public AllView getView()
        {
            return _view;
        }

        // constructor
        public AllController()
        {
            _view = new AllView(this);
            _model = new AllModel();
            

        }

        public void initialize()
        {
            maakTeerlingen();
        }
        private void maakTeerlingen()
        {
            for (int teerlingNummer = 0; teerlingNummer < _model.AantalTeerlingen; teerlingNummer++)
            {
                // Maak een nieuwe teerling aan
                TeerlingController teerling = new TeerlingController(this);
                teerling._model.Gekleurd = false;
                // Voeg de teerling toe aan het model
                _model.addTeerling(teerling);
                teerling.getView().updateViewTeerling();
            }
        }

        
        public AllModel getModel()
        {
            return _model;
        }
        public List<TeerlingView> getTeerlingenView()
        {
            // Maak een lijst die de views zal opvangen
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            // Loop over het huidig aantal teerlingen uit het model
            foreach (TeerlingController teerling in getModel().Teerlingen)
            {
                // Haal de view op voor iedere teerling
                TeerlingView teerlingView = teerling.getView();

                // Voeg de teerling toe aan de lijst die de views opvangt
                teerlingenView.Add(teerlingView);
            }

            // Return de lijst met teerlingViews
            return teerlingenView;
        }
        public void werpAlleTeerlingen()
        {
            List<TeerlingController> teerlingen = _model.Teerlingen; //krijg model voor alle teerlingen

            foreach (TeerlingController teerling in teerlingen)
            {
                teerling.werpTeerling();
                teerling.getView().updateViewTeerling();
            }
        }

    }
}
