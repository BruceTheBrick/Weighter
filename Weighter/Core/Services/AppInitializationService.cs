using Weighter.Core.Databases.Interfaces;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.Services
{
    public class AppInitializationService : IAppInitializationService
    {
        private readonly IWeighterDatabase _weighterDatabase;
        public AppInitializationService(IWeighterDatabase weighterDatabase)
        {
            _weighterDatabase = weighterDatabase;
        }

        public async Task Initialize()
        {
            _weighterDatabase.Initialize();
        }
    }
}