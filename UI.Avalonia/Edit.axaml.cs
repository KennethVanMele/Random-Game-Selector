using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace UI.Avalonia
{
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object? sender, RoutedEventArgs e)
        {

        }
        private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
    }
}