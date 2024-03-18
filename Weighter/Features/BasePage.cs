using System.Diagnostics.CodeAnalysis;

namespace Weighter.Features;

[ExcludeFromCodeCoverage]
public class BasePage : ContentPage
{
    public BasePage()
    {
        NavigationPage.SetHasNavigationBar(this, false);
    }
}