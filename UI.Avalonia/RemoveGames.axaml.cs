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
    private List<GameRow> allRows = new();

    public RemoveGames()
    {
        InitializeComponent();
    }

    private void Window_Opened(object? sender, EventArgs e)
    {
        allRows = gCont.GetGames()
            .Select(g => new GameRow { Id = g.Id, Title = g.Title, Platform = g.Platform.PlatformName })
            .ToList();
        ApplyFilter();
    }

    private void TxtFilter_TextChanged(object? sender, TextChangedEventArgs e) => ApplyFilter();

    private void ApplyFilter()
    {
        var filter = txtFilter.Text?.Trim() ?? string.Empty;
        lbGames.ItemsSource = allRows
            .Where(r => r.Title.Contains(filter, StringComparison.CurrentCultureIgnoreCase))
            .ToList();
    }

    private void BtnEdit_Click(object? sender, RoutedEventArgs e) => new Edit().Show();

    private void BtnRemove_Click(object? sender, RoutedEventArgs e)
    {
        // Use allRows, not the filtered view, so checks survive changing the filter.
        var ids = allRows
            .Where(r => r.Remove)
            .Select(r => r.Id)
            .ToList();

        if (ids.Count > 0)
            gCont.RemoveGames(ids);

        Close();
    }

    private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
}
