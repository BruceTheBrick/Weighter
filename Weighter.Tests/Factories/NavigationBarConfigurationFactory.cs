using Bogus;
using Weighter.Core.Models.UI;

namespace Weighter.Tests.Factories
{
    public static class NavigationBarConfigurationFactory
    {
        public static NavigationBarConfiguration GetModel()
        {
            return GetModels(1).First();
        }

        public static IList<NavigationBarConfiguration> GetModels(int count = 5)
        {
            return new Faker<NavigationBarConfiguration>()
                .RuleFor(x => x.Text, f => f.Random.Words())
                .RuleFor(x => x.AccessibilityName, f => f.Random.Words())
                .RuleFor(x => x.IconSource, f => f.Image.PlaceholderUrl(24, 24))
                .RuleFor(x => x.IsInAccessibleTree, f => f.Random.Bool())
                .Generate(count);
        }
    }
}