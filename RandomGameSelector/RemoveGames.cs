using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BL;
using Domain;

namespace RandomGameSelector
{
    public partial class RemoveGames : Form
    {
        private readonly GameController gCont = new GameController();

        public RemoveGames()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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

        private void BtnRm_Click(object sender, EventArgs e)
        {
            lbRemove.Items.Add(lbKeep.SelectedItem);
            lbKeep.Items.Remove(lbKeep.SelectedItem);
        }

        private void BtnKeep_Click(object sender, EventArgs e)
        {
            lbKeep.Items.Add(lbRemove.SelectedItem);
            lbRemove.Items.Remove(lbRemove.SelectedItem);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
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
