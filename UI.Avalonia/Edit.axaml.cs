using Avalonia.Controls;
using Avalonia.Interactivity;

namespace UI.Avalonia
{
    public partial class Edit : Window
    {
        private readonly GameRow row;
        public Edit() : this(new GameRow()) { }

        public Edit(GameRow row)
        {
            InitializeComponent();
            this.row = row;
            txtGame.Text = row.Title;
        }

        private void BtnSave_Click(object? sender, RoutedEventArgs e)
        {

        }
        private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
    }
}