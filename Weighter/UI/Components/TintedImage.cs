using CommunityToolkit.Maui.Behaviors;

namespace Weighter.UI;

public class TintedImage : Image
{
    public static readonly BindableProperty TintColorProperty = BindableProperty.Create(
        nameof(TintColor),
        typeof(Color),
        typeof(TintedImage),
        propertyChanged: TintColorChanged);

    public TintedImage()
    {
    }

    public Color TintColor
    {
        get => (Color)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }

    private static void TintColorChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        if (!(bindable is TintedImage image))
        {
            return;
        }

        ApplyTintBehavior(image, (Color)newvalue);
    }

    private static void ApplyTintBehavior(TintedImage image, Color tintColor)
    {
        var behavior = image.Behaviors.FirstOrDefault(x => x.GetType() == typeof(IconTintColorBehavior));
        if (behavior is IconTintColorBehavior tintColorBehavior)
        {
            tintColorBehavior.TintColor = tintColor;
            return;
        }

        image.Behaviors.Add(new IconTintColorBehavior { TintColor = tintColor });
    }
}