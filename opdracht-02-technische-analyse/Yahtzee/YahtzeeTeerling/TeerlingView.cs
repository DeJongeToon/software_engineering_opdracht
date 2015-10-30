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
    public partial class TeerlingView : UserControl
    {
        private TeerlingController _controller;

        // Constructor met bovenliggende controller als parameter
        public TeerlingView( TeerlingController controller)
        {
            // Vang het controller argument op zodat de rest van de view-methodes
            // de controller-methodes kunnen aanspreken
            InitializeComponent();
            _controller = controller;
            
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }
        public TeerlingController getController()
        {
            return _controller;
        }
        // Wanneer er op de werpknop wordt geklikt
        private void werpButton_Click(object sender, EventArgs e)
        {
            if (!_controller.Vast)
            {teerlingLabel.BackColor = (_controller.Vast) ? Color.Purple : default(Color);
            teerlingLabel.Text = _controller.AantalOgen.ToString();
                _controller.Werp();
            }
        }

        public void updateUI()
        {
            teerlingLabel.BackColor = (_controller.Vast) ? Color.Purple : default(Color);
            teerlingLabel.Text = _controller.AantalOgen.ToString();
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
            _controller.toggleKleur();
            updateStyles();
        }

        public void updateViewTeerling()
        {
            teerlingLabel.Text = _controller._model.Aantalogen.ToString();
            werpButton.Visible = _controller._model.ToonWerp;
            updateStyles();
        }
      
        private void updateStyles()
        {
            if (_controller._model.Gekleurd)
            {
                teerlingLabel.BackColor = Color.Purple;
            }
            else
            {
                teerlingLabel.BackColor = default(Color);
            }
        }
    }
}
