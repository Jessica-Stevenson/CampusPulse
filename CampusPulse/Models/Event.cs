using SQLite;

namespace CampusPulse.Models
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int EventId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string Location { get; set; } = string.Empty;

        [Indexed]
        public int CategoryId { get; set; }

        [Indexed]
        public int CreatedBy { get; set; }

        public bool IsActive { get; set; } = true;
    }
}