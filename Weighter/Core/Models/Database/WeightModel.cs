using System.ComponentModel.DataAnnotations.Schema;
using SQLite;
using Weighter.Core.Constants;

namespace Weighter.Core.Models.Database;

[SQLite.Table(DbConstants.WeightTable)]
public class WeightModel : BaseTable
{
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }
    [ForeignKey(nameof(UserModel))]
    public int UserId { get; set; }
    public decimal Weight { get; set; }
}