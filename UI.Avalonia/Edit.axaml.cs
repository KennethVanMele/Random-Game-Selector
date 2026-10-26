using Avalonia.Controls;
using Avalonia.Interactivity;

namespace UI.Avalonia
{
    public partial class Edit : Window
    {
        private readonly GameRow row;
        public Edit() : this(new GameRow()) { }
        private readonly BL.GameController gCont = new();

        public Edit(GameRow row)
        {
            InitializeComponent();
            this.row = row;
            txtGame.Text = row.Title;
        }

        private void BtnSave_Click(object? sender, RoutedEventArgs e)
        {
            var title = txtGame.Text?.Trim();
            if (string.IsNullOrWhiteSpace(txtGame.Text))
                return;

            //new BL.GameController().RenameGame(row.Id, txtGame.Text);
            gCont.RenameGame(row.Id, title);
            row.Title = title;
            Close();
        }
        private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
    }
}