using SQLite;

namespace CampusPulse.Models
{
    public class Comment
    {
        [PrimaryKey, AutoIncrement]
        public int CommentId { get; set; }

        [Indexed]
        public int PostId { get; set; }

        [Indexed]
        public int UserId { get; set; }

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsHidden { get; set; } = false;
    }
}