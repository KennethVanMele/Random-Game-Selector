using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public partial class AddGame : Window
{
    private readonly GameController gCont = new();
    private readonly PlatformController pCont = new();

    public AddGame()
    {
        InitializeComponent();
        FillCombobox();
    }

    private void FillCombobox()
    {
        cmbPlatform.ItemsSource = pCont.GetPlatform().Select(p => p.PlatformName).ToList();
    }

    private void BtnAddGame_Click(object? sender, RoutedEventArgs e)
    {
        if (cmbPlatform.SelectedItem is not string platform || string.IsNullOrWhiteSpace(txtTitle.Text))
            return;

        gCont.AddGame(txtTitle.Text, platform);
        txtTitle.Clear();

        if (cbMulti.IsChecked != true)
            Close();
    }

    private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
}
