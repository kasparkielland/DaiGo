namespace DaiGo.Model
{
    public class RequestModel { }

    public class Request
    {
        private int requestID, userID, agentID;
        private double minPrice, maxPrice;
        private string country, description;

        public int RequestID
        {
            get
            {
                return requestID;
            }
            set
            {
                if (requestID != value)
                {
                    requestID = value;
                }
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (userID != value)
                {
                    userID = value;
                }
            }
        }

        public int AgentID
        {
            get
            {
                return agentID;
            }
            set
            {
                if (agentID != value)
                {
                    agentID = value;
                }
            }
        }

        public double MinPrice
        {
            get
            {
                return minPrice;
            }
            set
            {
                if (minPrice != value)
                {
                    minPrice = value;
                }
            }
        }

        public double MaxPrice
        {
            get
            {
                return maxPrice;
            }
            set
            {
                if (maxPrice != value)
                {
                    maxPrice = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (country != value)
                {
                    country = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                }
            }
        }
    }
}