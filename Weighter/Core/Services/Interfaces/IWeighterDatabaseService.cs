using Weighter.Core.Models;

namespace Weighter.Core.Services.Interfaces
{
    public interface IWeighterDatabaseService
    {
        int CreateOrUpdateRecord(WeightEntry weightEntry);
        IEnumerable<WeightEntry> FetchAll();
        IEnumerable<WeightEntry> Fetch(int startIndex, int numRecords);
    }
}