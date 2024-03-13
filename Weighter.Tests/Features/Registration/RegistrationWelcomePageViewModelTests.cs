namespace Weighter.Tests.Features;

public class RegistrationWelcomePageViewModelTests : UnitTestBase<RegistrationWelcomePageViewModel>
{
    #region ContinueCommand

    [Fact]
    public async Task ContinueCommand_ShouldNavigateToUserDetailsRegistrationPage()
    {
        //Arrange

        //Act
        await Sut.ContinueCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync(Routes.RegistrationUserDetailsPage));
    }

    #endregion
}