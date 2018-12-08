using System;
using System.Windows.Forms;
using BL;
using Domain;

namespace RandomGameSelector
{
    public partial class Main : Form
    {
        private readonly PlatformController pCont = new PlatformController();
        private readonly GameController gCont = new GameController();
        public Main()
        {
            InitializeComponent();
            //getGame();
        }

        private void GetGame()
        {
            lblPlatform.Text = pCont.PlatformNaam();
            lblGame.Text = gCont.GameNaam();
        }

        private void BtnGetGame_Click(object sender, EventArgs e)
        {
            GetGame();
        }

        private void SmiAddGame_Click(object sender, EventArgs e)
        {
            new AddGame().Show();
        }

        private void SmiAddPlatform_Click(object sender, EventArgs e)
        {
            new AddPlatform().Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveGames().Show();
        }
    }
}
