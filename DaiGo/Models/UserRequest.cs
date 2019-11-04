using SQLite;

namespace DaiGo.Models
{
    public class UserRequest
    {
        [PrimaryKey, AutoIncrement]
        public int RequestID { get; set; }
        public string Subject { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
    }
}
