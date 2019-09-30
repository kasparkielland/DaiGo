using System;
using SQLite;
namespace DaiGo.Models
{
    public class AgentProfile
    {
        [PrimaryKey, AutoIncrement]
        public int AgentID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Rating { get; set; }

    }
}
