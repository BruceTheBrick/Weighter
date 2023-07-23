using FluentAssertions;
using Microsoft.Maui.ApplicationModel;
using Weighter.Core.Services;
using Weighter.Tests.Base;
using Xunit;

namespace Weighter.Tests.Services
{
    public class ThemeServiceTests : UnitTestBase<ThemeService>
    {
        #region IsDarkMode

        [Fact]
        public void IsDarkMode_ShouldReturnTrue_WhenThemeIsDark()
        {
            //Arrange
            Sut.Theme = AppTheme.Dark;

            //Act
            var isDarkMode = Sut.IsDarkMode;

            //Assert
            isDarkMode.Should().BeTrue();
        }

        [Theory]
        [InlineData(AppTheme.Light)]
        [InlineData(AppTheme.Unspecified)]
        public void IsDarkMode_ShouldReturnFalse_WhenThemeIsNotDark(AppTheme theme)
        {
            //Arrange
            Sut.Theme = theme;

            //Act
            var isDarkMode = Sut.IsDarkMode;

            //Assert
            isDarkMode.Should().BeFalse();
        }

        #endregion
        
        #region IsLightMode

        [Fact]
        public void IsLightMode_ShouldReturnTrue_WhenThemeIsLight()
        {
            //Arrange
            Sut.Theme = AppTheme.Light;

            //Act
            var isLightMode = Sut.IsLightMode;

            //Assert
            isLightMode.Should().BeTrue();
        }

        [Theory]
        [InlineData(AppTheme.Dark)]
        [InlineData(AppTheme.Unspecified)]
        public void IsLightMode_ShouldReturnFalse_WhenThemeIsNotLight(AppTheme theme)
        {
            //Arrange
            Sut.Theme = theme;

            //Act
            var isLightMode = Sut.IsLightMode;

            //Assert
            isLightMode.Should().BeFalse();
        }

        #endregion
    }
}