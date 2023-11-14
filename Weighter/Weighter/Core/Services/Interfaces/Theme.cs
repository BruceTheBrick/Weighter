namespace Weighter.Core;

public class Theme
{
    public static Theme DarkMode = new Theme(AppTheme.Dark, "Dark Mode");
    public static Theme LightMode = new Theme(AppTheme.Light, "Light Mode");
    public static Theme System = new Theme(AppTheme.Unspecified, "Follow System Settings");

    public Theme(AppTheme theme, string name)
    {
        AppTheme = theme;
        Name = name;
    }

    public AppTheme AppTheme { get; }
    public string Name { get; }
}