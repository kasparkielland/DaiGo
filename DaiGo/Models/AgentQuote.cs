using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DaiGo.Models
{
    public class AgentQuote
    {
        [PrimaryKey, AutoIncrement]
        public int QuoteID { get; set; }
        public int Quote { get; set; }
        public int AgentID { get; set; }
        public int RequestID { get; set; }
    }
}