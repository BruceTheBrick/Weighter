using Bogus;
using Microsoft.Maui.ApplicationModel;
using Weighter.Core.Models.Database;

namespace Weighter.Tests.Factories
{
    public static class UserSettingsModelFactory
    {
        public static UserSettingsModel GetModel()
        {
            return GetModels(1).First();
        }

        public static IEnumerable<UserSettingsModel> GetModels(int count = 5)
        {
            return new Faker<UserSettingsModel>()
                .RuleFor(x => x.Id, f => f.IndexFaker)
                .RuleFor(x => x.AppTheme, f => f.PickRandomParam<AppTheme>())
                .RuleFor(x => x.UserId, f => f.Random.Int(1))
                .Generate(count);
        }
    }
}