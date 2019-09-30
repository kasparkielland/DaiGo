using System;
using SQLite;

namespace DaiGo.Models
{
    public class UserProfile
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }
        public int UserName { get; set; }
        public int Password { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public int Email { get; set; }
        public int Phonenumber { get; set; }
    }
}
