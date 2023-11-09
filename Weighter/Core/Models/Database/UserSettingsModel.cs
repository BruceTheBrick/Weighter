using System.ComponentModel.DataAnnotations.Schema;
using SQLite;
using Weighter.Core.Constants;

namespace Weighter.Core.Models.Database;

[SQLite.Table(DbConstants.UserSettingsTable)]
public class UserSettingsModel
{
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }

    [ForeignKey(nameof(UserModel))]
    public int UserId { get; set; }
    public AppTheme AppTheme { get; set; }
}