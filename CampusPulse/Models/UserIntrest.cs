using SQLite;

namespace CampusPulse.Models
{
    public class UserInterest
    {
        [PrimaryKey, AutoIncrement]
        public int UserInterestId { get; set; }

        [Indexed]
        public int UserId { get; set; }

        [Indexed]
        public int CategoryId { get; set; }
    }
}