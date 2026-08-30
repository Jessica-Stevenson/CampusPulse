using SQLite;

namespace CampusPulse.Models
{
    public class Report
    {
        [PrimaryKey, AutoIncrement]
        public int ReportId { get; set; }

        [Indexed]
        public int ReportedByUserId { get; set; }

        [Indexed]
        public int? PostId { get; set; }

        [Indexed]
        public int? CommentId { get; set; }

        public string Reason { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? ReviewedBy { get; set; }

        public DateTime? ReviewedDate { get; set; }
    }
}