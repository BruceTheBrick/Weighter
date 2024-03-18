namespace Weighter.Tests.Features;

public class DashboardPageViewModelTests : UnitTestBase<DashboardPageViewModel>
{
    #region NavigateToWeightSummaryPageCommand

    [Fact]
    public async Task NavigateToWeightSummaryPageCommand_ShouldNavigate()
    {
        //Arrange

        //Act
        await Sut.NavigateToWeightSummaryPageCommand.ExecuteAsync(null);

        //Assert
        Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.Navigate(Routes.WeightSummaryPage));
    }
        
    #endregion
}