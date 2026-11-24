using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace MarkdownViewer;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var filePath = desktop.Args is { Length: > 0 } ? desktop.Args[0] : null;

            desktop.MainWindow = new MainWindow(filePath);
        }

        base.OnFrameworkInitializationCompleted();
    }
}