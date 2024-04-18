namespace Notes.ViewModels;
using Avalonia.Controls.Selection;

public class MainWindowViewModel : ViewModelBase
{
    public string FileContent => "Welcome to Avalonia!";

    public SelectionModel<string> Selection { get; } = new();
}
