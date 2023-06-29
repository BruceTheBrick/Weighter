using Weighter.Core.Constants;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Models;
using Weighter.Core.Models.Database;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.DataLayers
{
    public class WeighterDataLayer : IWeighterDataLayer
    {
        private readonly ISqlClientService _db;
        public WeighterDataLayer(ISqlClientService sqlClientService)
        {
            _db = sqlClientService;
            _db.SetConnectionString(WeighterDbConnectionString());
        }

        public IEnumerable<WeightModel> FetchAll()
        {
            return _db.Table<WeightModel>().ToList();
        }

        public IEnumerable<WeightModel> Fetch(int startIndex, int numRecords)
        {
            var items = _db.Table<WeightModel>().ToList();
            var filteredItems = items.Where(x =>
                items.IndexOf(x) >= startIndex && items.IndexOf(x) <= startIndex + numRecords);
            return filteredItems;
        }

        private string WeighterDbConnectionString()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DbConstants.DbName);
        }
    }
}