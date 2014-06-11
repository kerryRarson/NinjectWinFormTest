using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest.Store
{
    public class California : ICaliStore
    {
        private long _storeID = 9999;
        public long StoreId { get { return _storeID; } set { _storeID = value; } }

        public string Name
        {
            get { return "Cali Store"; }
        }

        public bool IsStoreOpen(DateTime dateTime)
        {
           ////closed monday
           // if (dateTime.DayOfWeek == DayOfWeek.Monday)
           // {
           //     return false;
           // }
           // //closed new years day
           // if (dateTime.DayOfYear == 1 )
           // {
           //     return false;
           // }
           // //open 9 - 5
           // //open 9 - 5
           // if ((dateTime.Hour >= 9 && dateTime.Hour < 17))
           // {
           //     return true;
           // }
            return false;
            //always return false, it's in California & can't afford the taxes to be in business.
        }
    }
}
