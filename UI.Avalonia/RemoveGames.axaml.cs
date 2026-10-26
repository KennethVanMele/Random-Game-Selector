using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public class GameRow
{
    public int Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Platform { get; init; } = string.Empty;
    public bool Remove { get; set; }
}

public partial class RemoveGames : Window
{
    private readonly GameController gCont = new();

    public RemoveGames()
    {
        InitializeComponent();
    }

    private void Window_Opened(object? sender, EventArgs e)
    {
        lbGames.ItemsSource = gCont.GetGames()
            .Select(g => new GameRow { Id = g.Id, Title = g.Title, Platform = g.Platform.PlatformName })
            .ToList();
    }

    private void BtnRemove_Click(object? sender, RoutedEventArgs e)
    {
        var ids = ((IEnumerable<GameRow>)lbGames.ItemsSource!)
            .Where(r => r.Remove)
            .Select(r => r.Id)
            .ToList();

        if (ids.Count > 0)
            gCont.RemoveGames(ids);

        Close();
    }

    private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
}
