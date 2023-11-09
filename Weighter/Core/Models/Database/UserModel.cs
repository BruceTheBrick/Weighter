using SQLite;
using Weighter.Core.Constants;
using Weighter.Core.Enums;

namespace Weighter.Core.Models.Database;

[Table(DbConstants.UserTable)]
public class UserModel : BaseTable
{
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nickname { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime LastLogin { get; set; }
}