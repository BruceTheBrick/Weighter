namespace Weighter.Core;

public class ColorRef
{
    public Color Color { get; set; }

    public static implicit operator Color(ColorRef colorRef)
    {
        return colorRef.Color;
    }

    public Color ToColor()
    {
        return Color;
    }
}