using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DaiGo.Models.RequestModel;

namespace DaiGo.ViewModel
{
    public class EditRequestViewModel
    {

    }



}

// Either change the following namespace to the name of your project,   
// or name your project with the following name when you create it.  
namespace DaiGo.ViewModels
{
    // This is a simple customer class that   
    // implements the IPropertyChange interface.  
    public class DemoCustomer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // The constructor is private to enforce the factory pattern.  
        private DemoCustomer()
        {
            customerNameValue = "Customer";
            phoneNumberValue = "(312)555-0100";
        }

        // This is the public factory method.  
        public static DemoCustomer CreateNewCustomer()
        {
            return new DemoCustomer();
        }

        // This property represents an ID, suitable  
        // for use as a primary key in a database.  
        public Guid ID
        {
            get
            {
                return this.idValue;
            }
        }

        public string CustomerName
        {
            get
            {
                return this.customerNameValue;
            }

            set
            {
                if (value != this.customerNameValue)
                {
                    this.customerNameValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberValue;
            }

            set
            {
                if (value != this.phoneNumberValue)
                {
                    this.phoneNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}