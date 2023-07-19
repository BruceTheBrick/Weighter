namespace Weighter.Core.Models.UI
{
    public class NavigationBarConfiguration
    {
        public NavigationBarConfiguration()
        {
        }

        public NavigationBarConfiguration(string iconSource, string text, string accessibilityName, bool isInAccessibleTree)
        {
            IconSource = iconSource;
            Text = text;
            AccessibilityName = accessibilityName;
            IsInAccessibleTree = isInAccessibleTree;
        }

        public string IconSource { get; }
        public string Text { get; }
        public string AccessibilityName { get; }
        public bool IsInAccessibleTree { get; }
    }
}