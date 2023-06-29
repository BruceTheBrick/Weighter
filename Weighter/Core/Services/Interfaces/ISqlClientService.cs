using SQLite;

namespace Weighter.Core.Services.Interfaces
{
    public interface ISqlClientService
    {
        void SetConnectionString(string connectionString);
        CreateTableResult CreateTable<T>();
        TableQuery<T> Table<T>() where T : new();
        int Insert<T>(T value);
        int InsertRange<T>(IEnumerable<T> values);
        int Update<T>(T value);
        int UpdateRange<T>(IEnumerable<T> values);
        int CreateOrUpdate<T>(T value) where T : new();
    }
}