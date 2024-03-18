using Moq;

namespace Weighter.Tests.Features;

public class RegistrationUserDetailsPageViewModelTests : UnitTestBase<RegistrationUserDetailsPageViewModel>
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
    public async Task NextCommand_ShouldSetValidationMessage_WhenFirstNameIsNotEntered()
    {
        //Arrange
        Sut.RegistrationDetails = RegistrationDetailsFactory.GetViewModel();
        Sut.RegistrationDetails.User.FirstName = string.Empty;

        //Act
        await Sut.NextCommand.ExecuteAsync(null);

        //Assert
        Sut.ValidationMessage.Should().Be("")
    }

    [Fact]
    public async Task NextCommand_ShouldNavigateToThemeSelectionPage()
    {
        //Arrange

        //Act
        await Sut.NextCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.Navigate(Routes.RegistrationThemeSelectionPage));
    }

    #endregion

    #region BackCommand

    [Fact]
    public async Task BackCommand_ShouldGoBack()
    {
        //Arrange

        //Act
        await Sut.BackCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.GoBack());
    }

    #endregion
}