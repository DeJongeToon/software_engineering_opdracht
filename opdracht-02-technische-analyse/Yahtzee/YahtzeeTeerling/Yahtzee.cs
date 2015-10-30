using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            //toevoegen scorebord

            //toevoegen all button en restart
            AllController yahtzee = new AllController();
            AllView AllView = yahtzee.getView();
            AllView.Location = new Point(0, 60);
            yahtzee.initialize();
            Controls.Add(AllView);
        }

    }
}
