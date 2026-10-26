using Avalonia.Controls;
using Avalonia.Interactivity;
using BL;

namespace UI.Avalonia;

public partial class AddPlatform : Window
{
    private readonly PlatformController pCont = new();

    public AddPlatform()
    {
        InitializeComponent();
    }

    private void BtnAdd_Click(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtPlatform.Text))
            return;

        pCont.AddPlatform(txtPlatform.Text);
        Close();
    }

    private void BtnCancel_Click(object? sender, RoutedEventArgs e) => Close();
}
