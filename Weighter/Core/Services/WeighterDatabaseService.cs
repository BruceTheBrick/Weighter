using Weighter.Core.Constants;
using Weighter.Core.Models;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.Services
{
    public class WeighterDatabaseService : IWeighterDatabaseService
    {
        private readonly ISqlClientService _db;
        public WeighterDatabaseService(ISqlClientService sqlClientService)
        {
            _db = sqlClientService;
            _db.SetConnectionString(WeighterDbConnectionString());
        }

        public int CreateOrUpdateRecord(WeightEntry weightEntry)
        {
            var existingEntry = _db.Table<WeightEntry>().FirstOrDefault(x => x == weightEntry);
            if (existingEntry == null)
            {
                return _db.Insert(weightEntry);
            }

            return _db.Update(weightEntry);
        }

        public IEnumerable<WeightEntry> FetchAll()
        {
            return _db.Table<WeightEntry>().ToList();
        }

        public IEnumerable<WeightEntry> Fetch(int startIndex, int numRecords)
        {
            var items = _db.Table<WeightEntry>().ToList();
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