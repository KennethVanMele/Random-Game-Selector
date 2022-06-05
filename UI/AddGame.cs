using BL;
using Domain;

namespace UI
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

        private void fillCombobox()
        {
            var platforms = pCont.GetPlatform();
            foreach (Platform platform in platforms)
            {
                var naam = platform.PlatformName;
                cmbPlatform.Items.Add(naam);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            gCont.AddGame(txtTitle.Text, cmbPlatform.Text);
            txtTitle.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}