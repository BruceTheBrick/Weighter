namespace Weighter.Tests.Core;

public class AppInitializationServiceTests : UnitTestBase<AppInitializationService>
{
    #region Initialize

    [Fact]
    public async Task Initialize_ShouldInitializeWeighterDatabase()
    {
        //Arrange

        //Act
        await Sut.Initialize();

        //Assert
        Mocker.GetMock<IWeighterDatabase>().Verify(x => x.Initialize());
    }

    [Fact]
    public async Task Initialize_ShouldSetupThemeService()
    {
        //Arrange
        var theme = Faker.PickRandom<AppTheme>();
        Mocker.GetMock<IApplication>().Setup(x => x.UserAppTheme).Returns(theme);

        //Act
        await Sut.Initialize();

        //Assert
        Mocker.GetMock<IThemeService>().VerifySet(x => x.Theme = theme);
    }

    #endregion
}