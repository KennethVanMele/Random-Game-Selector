using BL;
using Domain;

namespace UI
{
    public partial class RemoveGames : Form
    {
        private readonly GameController gCont = new GameController();

        public RemoveGames()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemoveGames_Load(object sender, EventArgs e)
        {
            foreach (Game game in gCont.GetGames())
            {
                lbKeep.Items.Add(game.Title);
            }
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            lbRemove.Items.Add(lbKeep.SelectedItem);
            lbKeep.Items.Remove(lbKeep.SelectedItem);
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            lbKeep.Items.Add(lbRemove.SelectedItem);
            lbRemove.Items.Remove(lbRemove.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<String> gtr = new List<string>();
            foreach (String g in lbRemove.Items)
            {
                gtr.Add(g);
            }

            gCont.RemoveGames(gtr);

            Close();
        }
    }
}