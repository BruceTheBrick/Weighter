using CommunityToolkit.Maui.Behaviors;

namespace Weighter.UI.Components;

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
        var tintBehavior = image.Behaviors.FirstOrDefault(x => x.GetType() == typeof(IconTintColorBehavior));
        if (tintBehavior != null)
        {
            image.Behaviors.Remove(tintBehavior);
        }

        image.Behaviors.Add(new IconTintColorBehavior { TintColor = tintColor });
    }
}