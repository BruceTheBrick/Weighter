using Bogus;
using Weighter.Features.Registration.ViewModels;

namespace Weighter.Tests.Factories
{
    public static class RegistrationDetailsFactory
    {
        public static RegistrationDetailsViewModel GetViewModel()
        {
            return GetViewModels(1).First();
        }

        public static IEnumerable<RegistrationDetailsViewModel> GetViewModels(int count = 5)
        {
            return new Faker<RegistrationDetailsViewModel>()
                .RuleFor(x => x.User, UserModelFactory.GetModel())
                .RuleFor(x => x.Settings, UserSettingsModelFactory.GetModel())
                .Generate(count);
        }
    }
}