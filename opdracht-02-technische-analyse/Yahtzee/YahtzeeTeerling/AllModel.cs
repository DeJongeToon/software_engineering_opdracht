using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class AllModel
    {

        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        private int aantalTeerlingen = 5;
        private int maxAantalWorpen = 3;
        private int aantalWorpen = 0;

        public void addTeerling(TeerlingController teerling)
        {
            teerlingen.Add(teerling);
        }

        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }
        }

        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
            }
        }

        public int MaxAantalWorpen
        {
            get
            {
                return maxAantalWorpen;
            }
        }
        public int AantalWorpen
        {
            get
            {
                return aantalWorpen;
            }
            set
            {
                aantalWorpen = value;
            }
        }

    }
}
