using Weighter.Core.Databases.Interfaces;
using Weighter.Core.DataLayers;
using Weighter.Tests.Base;
using Weighter.Tests.Factories;
using Xunit;

namespace Weighter.Tests.Core.DataLayers
{
    public class RegistrationDataLayerTests : UnitTestBase<RegistrationDataLayer>
    {
        #region Register

        [Fact]
        public void Register_ShouldCreateNewUserRecordInLocalDatabase()
        {
            //Arrange
            var registrationDetails = RegistrationDetailsFactory.GetViewModel();

            //Act
            Sut.Register(registrationDetails);

            //Assert
            Mocker.GetMock<IWeighterDatabase>().Verify(x => x.Add(registrationDetails.User));
        }
        
        [Fact]
        public void Register_ShouldCreateNewUserSettingsRecordInLocalDatabase()
        {
            //Arrange
            var registrationDetails = RegistrationDetailsFactory.GetViewModel();

            //Act
            Sut.Register(registrationDetails);

            //Assert
            Mocker.GetMock<IWeighterDatabase>().Verify(x => x.Add(registrationDetails.Settings));
        }

        #endregion
    }
}