namespace Weighter.Features;

public class ExtendedImage : Image
{
    private const string ImageDirectory = "Weighter.Resources.Images.";
    public new static readonly BindableProperty SourceProperty = BindableProperty.Create(
        nameof(Source),
        typeof(string),
        typeof(ExtendedImage),
        propertyChanged: SourcePropertyChanged);

    private static void SourcePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        if (bindable is not ExtendedImage view)
        {
            return;
        }

        view.SetSource((string)newvalue);
    }

    public new string Source
    {
        get => (string)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    private void SetSource(string source)
    {
        source = FormatSource(source);
        base.Source = source;
    }

    private string FormatSource(string newSource)
    {
        return ImageDirectory + newSource;
    }
}