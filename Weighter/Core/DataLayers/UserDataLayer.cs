using Weighter.Core.Constants;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Models.Database;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.DataLayers
{
    public class UserDataLayer : IUserDataLayer
    {
        private readonly ISqlClientService _clientService;

        public UserDataLayer(ISqlClientService clientService)
        {
            _clientService = clientService;
            _clientService.SetConnectionString(DbConstants.DbName);
        }

        public bool AnyUsersRegistered()
        {
            return _clientService.Table<UserModel>().Any();
        }
    }
}