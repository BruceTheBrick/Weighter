using Weighter.Core.Enums;
using Weighter.Core.Services;
using Weighter.Tests.Base;
using Xunit;

namespace Weighter.Tests.Services
{
    public class NavigationBarConfigurationServiceTests : UnitTestBase<NavigationBarConfigurationService>
    {
        #region Configuration

        [Fact]
        public void Configuration_ShouldReturnCloseConfiguration_WhenActionTypeIsClose()
        {
            //Arrange
    
            //Act
            var configuration = NavigationBarConfigurationService.Configuration(NavigationBarActionType.Close);

            //Assert
        }

        #endregion
    }
}