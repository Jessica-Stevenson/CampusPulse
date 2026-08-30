using SQLite;

namespace CampusPulse.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int PostId { get; set; }

        [Indexed]
        public int UserId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        [Indexed]
        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        public bool IsHidden { get; set; } = false;
    }
}