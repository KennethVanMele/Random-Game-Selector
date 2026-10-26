using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public class GameRow
{
    public int Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public string Platform { get; init; } = string.Empty;
    public bool Remove { get; set; }
}

public partial class ManageGames : Window
{
    private readonly GameController gCont = new();
    private List<GameRow> allRows = new();

    public ManageGames()
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

    private async void BtnEdit_Click(object? sender, RoutedEventArgs e)
    {
        // Clicking a row's checkbox ticks it without selecting the row, so fall back to a single ticked row.
        var row = lbGames.SelectedItem as GameRow;
        if (row is null)
        {
            var ticked = allRows.Where(r => r.Remove).ToList();
            if (ticked.Count == 1)
                row = ticked[0];
        }

        if (row is null)
            return;

        await new Edit(row).ShowDialog(this);
        ApplyFilter();
    }

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
