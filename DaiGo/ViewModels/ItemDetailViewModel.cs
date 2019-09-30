using System;

<<<<<<< HEAD
<<<<<<< HEAD

namespace DaiGo.ViewModels
{
    //public class ItemDetailViewModel : BaseViewModel
    //{
    //    public Item Item { get; set; }
    //    public ItemDetailViewModel(Item item = null)
    //    {
    //        Title = item?.Text;
    //        Item = item;
    //    }
    //}
=======
=======
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
using DaiGo.Models;

namespace DaiGo.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
>>>>>>> parent of 7cae416... I have change Agent Page and related message page
}
