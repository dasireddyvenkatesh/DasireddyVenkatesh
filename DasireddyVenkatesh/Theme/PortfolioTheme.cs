using MudBlazor;

namespace DasireddyVenkatesh.Theme;

/// <summary>
/// Shared portfolio palette. Page components should use MudBlazor palette
/// tokens instead of introducing independent brand colors.
/// </summary>
public static class PortfolioTheme
{
    public static MudTheme Theme { get; } = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#087F68",
            PrimaryContrastText = "#FFFFFF",
            Secondary = "#5868CF",
            SecondaryContrastText = "#FFFFFF",
            Tertiary = "#087F68",
            Success = "#087F68",
            Info = "#5868CF",
            Dark = "#162329",
            Background = "#F5F7F8",
            Surface = "#FFFFFF",
            AppbarBackground = "#FFFFFF",
            AppbarText = "#162329",
            DrawerBackground = "#FFFFFF",
            DrawerText = "#34464D",
            TextPrimary = "#162329",
            TextSecondary = "#53636A",
            Divider = "#DCE4E5",
            LinesDefault = "#DCE4E5"
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#50D5AA",
            PrimaryContrastText = "#0B1514",
            Secondary = "#7C8CFF",
            SecondaryContrastText = "#101329",
            Tertiary = "#50D5AA",
            Success = "#50D5AA",
            Info = "#7C8CFF",
            Dark = "#0B0F14",
            Background = "#0B0F14",
            Surface = "#111820",
            AppbarBackground = "#111820",
            AppbarText = "#F5F7FA",
            DrawerBackground = "#111820",
            DrawerText = "#A7B0BC",
            TextPrimary = "#F5F7FA",
            TextSecondary = "#A7B0BC",
            Divider = "rgba(255,255,255,0.08)",
            LinesDefault = "rgba(255,255,255,0.08)"
        },
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "12px"
        }
    };
}
