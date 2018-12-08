using Domain;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGameSelector
{
    public partial class AddGame : Form
    {
        private GameController gCont = new GameController();
        private PlatformController pCont = new PlatformController();

        public AddGame()
        {
            InitializeComponent();
            fillCombobox();
            
        }

        private void fillCombobox() {
            var platformen = pCont.GetPlatform();
            foreach(Platform platform in platformen)
            {
                var naam = platform.PlatformName;
                cmbConsole.Items.Add(naam);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            gCont.AddGame(txtTitle.Text, cmbConsole.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
