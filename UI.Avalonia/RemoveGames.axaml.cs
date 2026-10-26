using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public partial class RemoveGames : Window
{
    private readonly GameController gCont = new();
    private readonly ObservableCollection<string> keep = new();
    private readonly ObservableCollection<string> remove = new();

    public RemoveGames()
    {
        InitializeComponent();
        lbKeep.ItemsSource = keep;
        lbRemove.ItemsSource = remove;
    }

    private void Window_Opened(object? sender, EventArgs e)
    {
        foreach (var game in gCont.GetGames())
            keep.Add(game.Title);
    }

    private static void Move(ListBox from, ObservableCollection<string> source, ObservableCollection<string> target)
    {
        if (from.SelectedItem is not string title)
            return;

        source.Remove(title);
        target.Add(title);
    }

    private void BtnRm_Click(object? sender, RoutedEventArgs e) => Move(lbKeep, keep, remove);

    private void BtnKeep_Click(object? sender, RoutedEventArgs e) => Move(lbRemove, remove, keep);

    private void BtnRemove_Click(object? sender, RoutedEventArgs e)
    {
        gCont.RemoveGames(remove.ToList());
        Close();
    }

    private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
}
