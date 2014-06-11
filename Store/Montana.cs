using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest.Store
{
    public class Montana : IStore

    {
        public long StoreId
        {
            get { return 1; }
        }

        public string Name
        {
            get { return "The Last Best Place!"; }
        }

        public bool IsStoreOpen(DateTime dateTime)
        {
            //closed on Sunday for church
            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
              return false;
            }
            //open 9 - 5
            if ((dateTime.Hour >= 9 && dateTime.Hour < 17))
            {
                return true;
            }
            return false;
        }
    }
}
