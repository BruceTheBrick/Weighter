using SQLite;

namespace Weighter.Core.Models
{
    public class WeightEntry : BaseTable
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public decimal Weight { get; set; }
    }
}