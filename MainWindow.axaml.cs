using System.IO;
using Avalonia.Controls;

namespace MarkdownViewer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public MainWindow(string? filePath = null)
    {
        InitializeComponent();

        if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
        {
            Viewer.AssetPathRoot = Path.GetDirectoryName(
                Path.GetFullPath(filePath)); 
            Viewer.Markdown = File.ReadAllText(filePath);
        }
    }
}