using SQLite;

namespace CampusPulse.Models
{
    public class EventRegistration
    {
        [PrimaryKey, AutoIncrement]
        public int RegistrationId { get; set; }

        [Indexed]
        public int EventId { get; set; }

        [Indexed]
        public int UserId { get; set; }

        public DateTime RegisteredDate { get; set; } = DateTime.Now;
    }
}