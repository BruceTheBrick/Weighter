using Weighter.Core.Constants;
using Weighter.Core.Databases;
using Weighter.Core.Models.Database;
using Weighter.Core.Services.Interfaces;
using Weighter.Tests.Base;
using Xunit;

namespace Weighter.Tests.Core.Databases
{
    public class WeighterDatabaseTests : UnitTestBase<WeighterDatabase>
    {
        #region Initialize

        [Fact]
        public void Initialize_ShouldSetConnectionString()
        {
            //Arrange

            //Act
            Sut.Initialize();

            //Assert
            Mocker.GetMock<ISqlClientService>().Verify(x => x.SetConnectionString(DbConstants.DbName));
        }

        [Fact]
        public void Initialize_ShouldCreateUserModelTable()
        {
            //Arrange

            //Act
            Sut.Initialize();

            //Assert
            Mocker.GetMock<ISqlClientService>().Verify(x => x.CreateTable<UserModel>());
        }
        
        [Fact]
        public void Initialize_ShouldCreateWeightModelTable()
        {
            //Arrange

            //Act
            Sut.Initialize();

            //Assert
            Mocker.GetMock<ISqlClientService>().Verify(x => x.CreateTable<WeightModel>());
        }
        
        [Fact]
        public void Initialize_ShouldCreateUserSettingsModelTable()
        {
            //Arrange

            //Act
            Sut.Initialize();

            //Assert
            Mocker.GetMock<ISqlClientService>().Verify(x => x.CreateTable<UserSettingsModel>());
        }

        #endregion
    }
}