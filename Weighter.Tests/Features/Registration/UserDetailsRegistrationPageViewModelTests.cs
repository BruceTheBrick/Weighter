using FluentAssertions;
using Weighter.Core.Services;
using Weighter.Features.Registration;
using Weighter.Tests.Base;
using Weighter.Tests.Factories;
using Xunit;

namespace Weighter.Tests.Features.Registration
{
    public class UserDetailsRegistrationPageViewModelTests : UnitTestBase<RegistrationUserDetailsPageViewModel>
    {
        #region OnNavigatedTo

        [Fact]
        public void OnNavigatedTo_ShouldSetRegistrationDetails_WhenRegistrationDetailsArePassed()
        {
            //Arrange
            var registrationDetails = RegistrationDetailsFactory.GetViewModel();
            var parameters = new NavigationParameters { { NavigationService.RegistrationDetails, registrationDetails } };

            //Act
            Sut.OnNavigatedTo(parameters);

            //Assert
            Sut.RegistrationDetails.Should().Be(registrationDetails);
        }

        #endregion
        
        #region NextCommand

        [Fact]
        public async Task NextCommand_ShouldNavigateToThemeSelectionPage()
        {
            //Arrange

            //Act
            await Sut.NextCommand.ExecuteAsync(null);

            //Assert
        }

        #endregion
    }
}