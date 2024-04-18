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

        string?[] pdfFiles = Directory.GetFiles("/home/alosuri/Documents/Notes/", "*.note").Select(Path.GetFileNameWithoutExtension).ToArray();
        filesListBox.ItemsSource = pdfFiles 
            .OrderBy(x => x);
    }
}
