using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public partial class MainWindow : Window
{
    private readonly PlatformController pCont = new();
    private readonly GameController gCont = new();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnGetGame_Click(object? sender, RoutedEventArgs e)
    {
        lblPlatform.Text = pCont.PlatformName();
        try
        {
            lblGame.Text = gCont.GameName();
        }
        catch (Exception)
        {
            // No games stored for the picked platform (or no platforms at all).
            lblGame.Text = "No games for this platform";
        }
    }

    private void SmiAddGame_Click(object? sender, RoutedEventArgs e) => new AddGame().Show();

    private void SmiAddPlatform_Click(object? sender, RoutedEventArgs e) => new AddPlatform().Show();

    private void ManageGames_Click(object? sender, RoutedEventArgs e) => new ManageGames().Show();

    private void Exit_Click(object? sender, RoutedEventArgs e) => Close();
}
