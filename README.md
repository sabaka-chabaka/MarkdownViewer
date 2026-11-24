# MarkdownViewer

A lightweight, modern, and fast Markdown viewer built with [.NET 10](https://dotnet.microsoft.com/) and [Avalonia UI](https://avaloniaui.net/). It features a sleek Windows Mica / Acrylic blurred transparent aesthetic and compiles ahead-of-time (Native AOT) for instant startup.

## Features

- **Modern Fluent UI**: Styled with Mica and Acrylic blur transparency effects and borderless title bar integration.
- **Rich Markdown Rendering**: Powered by [Markdown.Avalonia](https://github.com/whistyun/Markdown.Avalonia) with syntax highlighting support for code blocks.
- **Fast Startup & Native AOT**: Configured for Native AOT publishing and single-file executable distribution with minimal resource footprint.
- **Relative Asset Resolution**: Resolves relative image and document paths based on the open file's directory.
- **CLI & File Association Friendly**: Open files directly via command line arguments or default file handler.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later (for building from source)
- Windows 10/11 (or compatible desktop platforms supported by Avalonia)

## Getting Started

### Clone & Run

```bash
git clone https://github.com/sabaka-chabaka/MarkdownViewer.git
cd MarkdownViewer
dotnet run -- path/to/document.md
```

### Usage

Pass the Markdown file path as the first argument:

```bash
MarkdownViewer path\to\document.md
```

You can also associate `.md` files in Windows to open directly with `MarkdownViewer.exe`.

## Building & Publishing

### Debug Build

```bash
dotnet build
```

### Native AOT Single-File Release

To create a trimmed, standalone, ahead-of-time compiled executable:

```bash
dotnet publish -c Release -r win-x64
```

The resulting single-file executable will be available under `bin/Release/net10.0/win-x64/publish/`.

## Tech Stack

- **UI Framework**: [Avalonia UI 12](https://avaloniaui.net/)
- **Themes**: [FluentAvaloniaUI](https://github.com/amwx/FluentAvalonia) & Avalonia.Themes.Fluent
- **Markdown**: [Markdown.Avalonia](https://github.com/whistyun/Markdown.Avalonia)
- **Target Framework**: .NET 10.0 (`net10.0`)

## License

This project is licensed under the [MIT License](LICENSE.md).
