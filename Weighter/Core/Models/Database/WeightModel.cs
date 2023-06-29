using SQLite;

namespace Weighter.Core.Models.Database
{
    public class WeightModel : BaseTable
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public decimal Weight { get; set; }
    }
}