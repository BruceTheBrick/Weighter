using SQLite;

namespace Weighter.Core.Services.Interfaces
{
    public interface ISqlClientService
    {
        void SetConnectionString(string connectionString);
        CreateTableResult CreateTable<T>();
        TableQuery<T> Table<T>() where T : new();
        int Insert<T>(T value);
        int Update<T>(T value);
    }
}