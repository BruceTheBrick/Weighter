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
    public async Task Initialize_ShouldSetupThemeService_WhenCurrentIsNotNull()
    {
        //Arrange

        //Act
        await SutMock.Object.Initialize();

        //Assert
        SutMock.Verify(x => x.SetupThemeService());
    }

    #endregion
}