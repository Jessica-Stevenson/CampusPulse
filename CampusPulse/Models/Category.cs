using SQLite;

namespace CampusPulse.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }

        [Unique]
        public string Name { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}