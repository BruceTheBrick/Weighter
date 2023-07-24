using Bogus;
using FluentAssertions;
using Weighter.Tests.Base;
using Weighter.Tests.Factories;
using Xunit;

namespace Weighter.Tests.Features.Registration._ViewModels
{
    public class RegistrationDetailsViewModelTests : UnitTestBase
    {
        #region LinkSettingsToUser

        [Fact]
        public void LinkSettingsToUser_ShouldSetSettingsUserIdToUserId()
        {
            //Arrange
            var registrationViewModel = RegistrationDetailsFactory.GetViewModel();
            registrationViewModel.User.Id = Faker.Random.Int(1);
            registrationViewModel.Settings.UserId = Faker.Random.Int(1);

            //Act
            registrationViewModel.LinkSettingsToUser();

            //Assert
            registrationViewModel.User.Id.Should().Be(registrationViewModel.Settings.UserId);
        }

        #endregion
    }
}