using BL;

namespace UI
{
    public partial class Main : Form
    {
        private readonly PlatformController pCont = new PlatformController();
        private readonly GameController gCont = new GameController();

        public Main()
        {
            InitializeComponent();
        }

        private void GetGame()
        {
            lblPlatform.Text = pCont.PlatformName();
            lblGame.Text = gCont.GameName();
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