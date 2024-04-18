using Avalonia.Controls;
using System.Linq;
using System.IO;
using System;

namespace Notes.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        string?[] files = Directory.GetFiles("/home/alosuri/Documents/Notes/", "*.note").Select(Path.GetFileNameWithoutExtension).ToArray();
        filesBox.ItemsSource = files 
            .OrderBy(x => x);
    }

}
