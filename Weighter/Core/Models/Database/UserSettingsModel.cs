using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

namespace Weighter.Core;

[SQLite.Table(DbConstants.UserSettingsTable)]
public class UserSettingsModel : BaseTable
{
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }

    [ForeignKey(nameof(UserModel))]
    public int UserId { get; set; }
    public AppTheme AppTheme { get; set; }
}