using Bitspace.Tests.Base;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;
using Weighter.Features.Weight_Tracking;
using Xunit;

namespace Weighter.Tests.Features.Dashboard
{
    public class DashboardPageViewModelTests : UnitTestBase<DashboardPageViewModel>
    {
        #region NavigateToWeightSummaryPageCommand

        [Fact]
        public async Task NavigateToWeightSummaryPageCommand_ShouldNavigate()
        {
            //Arrange

            //Act
            Sut.NavigateToWeightSummaryPageCommand.Execute(null);

            //Assert
            Mocker.GetMock<IBaseService>().Verify(x => x.NavigationService.NavigateAsync(nameof(WeightSummaryPage)));
        }
        
        #endregion
    }
}