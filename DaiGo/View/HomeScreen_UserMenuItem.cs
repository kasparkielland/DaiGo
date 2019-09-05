using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaiGo.View
{
    public class HomeScreen_UserMenuItem
    {
        public HomeScreen_UserMenuItem()
        {
            TargetType = typeof(HomeScreen_UserDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
