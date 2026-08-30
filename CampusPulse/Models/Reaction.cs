using SQLite;

namespace CampusPulse.Models
{
    public class Reaction
    {
        [PrimaryKey, AutoIncrement]
        public int ReactionId { get; set; }

        [Indexed]
        public int PostId { get; set; }

        [Indexed]
        public int UserId { get; set; }

        public string ReactionType { get; set; } = "Like";
    }
}