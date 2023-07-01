using Weighter.Core.Constants;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Models.Database;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.DataLayers
{
    public class WeighterDatabase : IWeighterDatabase
    {
        private readonly ISqlClientService _db;
        public WeighterDatabase(ISqlClientService db)
        {
            _db = db;
        }

        public void Initialize()
        {
            _db.SetConnectionString(DbConstants.DbName);
            _db.CreateTable<UserModel>();
            _db.CreateTable<WeightModel>();
            _db.CreateTable<UserSettingsModel>();
        }
    }
}