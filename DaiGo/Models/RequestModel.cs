using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace DaiGo.Models.RequestModel
{
    public class RequestModel { }

    public class Request : INotifyCompletion
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private Guid requestID = new Guid(), userID = new Guid(), agentID = new Guid();
        private double minPrice, maxPrice;
        private string country = String.Empty, description = String.Empty;

        public Guid RequestID
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
                    NotifyPropertyChanged();
                }
            }
        }

        public Guid UserID
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
                    NotifyPropertyChanged();
                }
            }
        }

        public Guid AgentID
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
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
                    NotifyPropertyChanged();
                }
            }
        }

        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }
    }
}