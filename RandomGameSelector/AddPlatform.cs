using BL;
using System;
using System.Windows.Forms;

namespace RandomGameSelector
{
    public partial class AddPlatform : Form
    {
        private readonly PlatformController pCont = new PlatformController();

        public AddPlatform()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pCont.AddPlatform(txtPlatform.Text);
            Close();
        }
    }
}
