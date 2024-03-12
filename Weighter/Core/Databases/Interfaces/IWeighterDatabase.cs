using SQLite;

namespace Weighter.Core;

public interface IWeighterDatabase
{
    public void Initialize();
    public TableQuery<T> Table<T>() where T : new();
    public int Add<T>(T user) where T : new();
    public int CreateOrUpdate<T>(T data) where T : new();
}