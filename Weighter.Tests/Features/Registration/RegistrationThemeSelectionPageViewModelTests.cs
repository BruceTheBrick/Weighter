using Moq;

namespace Weighter.Tests.Features;

public class RegistrationThemeSelectionPageViewModelTests : UnitTestBase<RegistrationThemeSelectionPageViewModel>
{
    #region OnNavigatedTo

    [Fact]
    public void OnNavigatedTo_ShouldSetRegistrationDetails_WhenPassedInParameters()
    {
        //Arrange
        var registrationDetails = RegistrationDetailsFactory.GetViewModel();
        var parameters = new NavigationParameters {{NavigationService.RegistrationDetails, registrationDetails}};

        //Act
        Sut.OnNavigatedTo(parameters);

        //Assert
        Sut.RegistrationDetails.Should().Be(registrationDetails);
    }

    #endregion

    #region IsDarkModeEnabled

    [Fact]
    public void IsDarkModeEnabled_ShouldSetThemeToDark_WhenSetToTrue()
    {
        //Arrange
        Sut.RegistrationDetails = new RegistrationDetailsViewModel();

        //Act
        Sut.IsDarkModeEnabled = true;

        //Assert
        Mocker.GetMock<IThemeService>().VerifySet(x => x.Theme = AppTheme.Dark);
    }
        
    [Fact]
    public void IsDarkModeEnabled_ShouldSetRegistrationDetailsAppThemeToDark_WhenSetToTrue()
    {
        //Arrange
        Sut.RegistrationDetails = new RegistrationDetailsViewModel();

        //Act
        Sut.IsDarkModeEnabled = true;

        //Assert
        Sut.RegistrationDetails.Settings.AppTheme.Should().Be(AppTheme.Dark);
    }
        
    [Fact]
    public void IsLightModeEnabled_ShouldSetThemeToLight_WhenSetToFalse()
    {
        //Arrange
        Sut.RegistrationDetails = new RegistrationDetailsViewModel();
        Mocker.GetMock<IThemeService>().Setup(x => x.IsDarkMode).Returns(true);

        //Act
        Sut.IsDarkModeEnabled = false;

        //Assert
        Mocker.GetMock<IThemeService>().VerifySet(x => x.Theme = AppTheme.Light);
    }
        
    [Fact]
    public void IsLightModeEnabled_ShouldSetRegistrationDetailsAppThemeToLight_WhenSetToFalse()
    {
        //Arrange
        Sut.RegistrationDetails = new RegistrationDetailsViewModel();
        Mocker.GetMock<IThemeService>().Setup(x => x.IsDarkMode).Returns(true);

        //Act
        Sut.IsDarkModeEnabled = false;

        //Assert
        Sut.RegistrationDetails.Settings.AppTheme.Should().Be(AppTheme.Light);
    }

    #endregion

    #region ContinueCommand

    [Fact]
    public async Task ContinueCommand_ShouldNavigateToDashboard_WhenRegistrationIsSuccessful()
    {
        //Arrange
        Sut.RegistrationDetails = RegistrationDetailsFactory.GetViewModel();
        Mocker.GetMock<IRegistrationDataLayer>().Setup(x => x.Register(Sut.RegistrationDetails)).Returns(true);

        //Act
        await Sut.ContinueCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync($"/{Routes.NavigationPage}/{Routes.DashboardPage}"));
    }

    [Fact]
    public async Task ContinueCommand_ShouldNotNavigate_WhenRegistrationIsUnsuccessful()
    {
        //Arrange
        Mocker.GetMock<IRegistrationDataLayer>().Setup(x => x.Register(It.IsAny<RegistrationDetailsViewModel>())).Returns(false);

        //Act
        await Sut.ContinueCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync($"/{Routes.NavigationPage}/{Routes.DashboardPage}"), Times.Never);
    }

    #endregion
}