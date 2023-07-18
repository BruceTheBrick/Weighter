using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration;
using Weighter.Tests.Base;
using Xunit;

namespace Weighter.Tests.Features.Registration
{
    public class WelcomePageViewModelTests : UnitTestBase<RegistrationWelcomePageViewModel>
    {
        #region ContinueCommand

        [Fact]
        public async Task ContinueCommand_ShouldNavigateToUserDetailsRegistrationPage()
        {
            //Arrange

            //Act
            await Sut.ContinueCommand.ExecuteAsync(null);

            //Assert
            Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync(nameof(RegistrationUserDetailsPage)));
        }

        #endregion
    }
}