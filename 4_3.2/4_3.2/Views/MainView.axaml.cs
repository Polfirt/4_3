using Avalonia.Controls;
using Avalonia.Interactivity;

namespace _4_3._2.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        message.Text = "Liked!";
    }
}
