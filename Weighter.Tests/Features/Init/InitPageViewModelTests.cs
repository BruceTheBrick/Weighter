namespace Weighter.Tests.Features;

public class InitPageViewModelTests : UnitTestBase<InitPageViewModel>
{
    #region OnNavigatedToAsync

    [Fact]
    public async Task OnNavigatedToAsync_ShouldInitializeAppInitializationService()
    {
        //Arrange

        //Act
        await Sut.OnNavigatedToAsync(new NavigationParameters());

        //Assert
        Mocker.GetMock<IAppInitializationService>().Verify(x => x.Initialize());
    }

    [Fact]
    public async Task OnNavigatedToAsync_ShouldNavigateToLoginPage_WhenRegisteredUsersExist()
    {
        //Arrange
        Mocker.GetMock<IUserDataLayer>().Setup(x => x.AnyUsersRegistered()).Returns(true);

        //Act
        await Sut.OnNavigatedToAsync(new NavigationParameters());

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(LoginPage)}"));
    }

    [Fact]
    public async Task OnNavigatedToAsync_ShouldNavigateToWelcomePage_WhenNoRegisteredUsersExist()
    {
        //Arrange
        Mocker.GetMock<IUserDataLayer>().Setup(x => x.AnyUsersRegistered()).Returns(false);

        //Act
        await Sut.OnNavigatedToAsync(new NavigationParameters());

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(RegistrationWelcomePage)}"));
    }

    [Fact]
    public async Task OnNavigatedToAsync_ShouldLogException_WhenExceptionIsThrown()
    {
        //Arrange
        var exception = new Exception();
        Mocker.GetMock<IAppInitializationService>().Setup(x => x.Initialize()).Throws(exception);

        //Act
        await Sut.OnNavigatedToAsync(new NavigationParameters());

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.LoggerService.LogException(exception));
    }

    #endregion
}