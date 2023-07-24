using FluentAssertions;
using Weighter.Core.Enums;
using Weighter.Core.Services;
using Weighter.Resources.Copy_Registers;
using Weighter.Tests.Base;
using Xunit;

namespace Weighter.Tests.Core.Services
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
            configuration.IconSource.Should().Be("ic_close");
            configuration.Text.Should().Be(GlobalRegister.GLOBAL_003);
            configuration.AccessibilityName.Should().Be(GlobalRegister.GLOBAL_003);
            configuration.IsInAccessibleTree.Should().BeTrue();
        }
        
        [Fact]
        public void Configuration_ShouldReturnBackConfiguration_WhenActionTypeIsBack()
        {
            //Arrange
    
            //Act
            var configuration = NavigationBarConfigurationService.Configuration(NavigationBarActionType.Back);

            //Assert
            configuration.IconSource.Should().Be("ic_left_arrow");
            configuration.Text.Should().Be(GlobalRegister.GLOBAL_004);
            configuration.AccessibilityName.Should().Be(GlobalRegister.GLOBAL_004);
            configuration.IsInAccessibleTree.Should().BeTrue();
        }
        
        [Fact]
        public void Configuration_ShouldReturnNextConfiguration_WhenActionTypeIsNext()
        {
            //Arrange
    
            //Act
            var configuration = NavigationBarConfigurationService.Configuration(NavigationBarActionType.Next);

            //Assert
            configuration.IconSource.Should().Be("ic_right_arrow");
            configuration.Text.Should().Be(GlobalRegister.GLOBAL_002);
            configuration.AccessibilityName.Should().Be(GlobalRegister.GLOBAL_002);
            configuration.IsInAccessibleTree.Should().BeTrue();
        }
        
        [Fact]
        public void Configuration_ShouldReturnDoneConfiguration_WhenActionTypeIsDone()
        {
            //Arrange
    
            //Act
            var configuration = NavigationBarConfigurationService.Configuration(NavigationBarActionType.Done);

            //Assert
            configuration.IconSource.Should().Be(string.Empty);
            configuration.Text.Should().Be(GlobalRegister.GLOBAL_005);
            configuration.AccessibilityName.Should().Be(GlobalRegister.GLOBAL_005);
            configuration.IsInAccessibleTree.Should().BeTrue();
        }
        
        [Fact]
        public void Configuration_ShouldReturnNoneConfiguration_WhenActionTypeIsNone()
        {
            //Arrange
    
            //Act
            var configuration = NavigationBarConfigurationService.Configuration(NavigationBarActionType.None);

            //Assert
            configuration.IconSource.Should().Be(string.Empty);
            configuration.Text.Should().Be(string.Empty);
            configuration.AccessibilityName.Should().Be(string.Empty);
            configuration.IsInAccessibleTree.Should().BeFalse();
        }

        #endregion
    }
}