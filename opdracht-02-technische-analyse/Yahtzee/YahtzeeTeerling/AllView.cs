using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class AllView : UserControl
    {

        private AllController _controller;

        public AllView(AllController Contr) {

            InitializeComponent();
            _controller = Contr;

         } 
       

        private void bttn_all_Click(object sender, EventArgs e)
        {
            _controller.getModel().AantalWorpen++;
            if (_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen)
            {
                _controller.werpAlleTeerlingen(); //controller teerling laten werpen
                if (_controller.getModel().AantalWorpen + 1 > _controller.getModel().MaxAantalWorpen)
                {
                    btnn_start_again.Visible = true;
                }
            }

        }

        private void AllView_Load(object sender, EventArgs e)
        {
            List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
            int teerlingWidth = teerlingen[0].Width; //breedte van 1 teerling voor correct naast elkaar

            foreach (TeerlingView teerling in teerlingen)
            {
                TeerlingView huidigeTeerling = teerling;

                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth; //x positie zetten afhankelijk van index en width
                huidigeTeerling.Location = new Point(xPos, 0);

                Controls.Add(huidigeTeerling); //huidige teerling toevoegen aan view

                huidigeTeerling.updateViewTeerling();
            }
            
            bttn_all.Location = new Point(20, teerlingen[0].Height); //Smijt alle teerlingen onder de teerling zetten
            btnn_start_again.Location = new Point((25 + bttn_all.Width), teerlingen[0].Height);

            btnn_start_again.Visible = !(_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen);
        }

        private void btnn_start_again_Click(object sender, EventArgs e)
        {
            //spel reseten
            _controller.getModel().AantalWorpen = 0;

            bttn_all.Visible = false;
            List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
            foreach (var teerling in teerlingen)
            {
                teerling.getController().resetTeerling();
            }
        }
    }
}
