using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest.Store
{
    public interface IStore
    {
        long StoreId { get; }
        string Name { get; }
        bool IsStoreOpen(DateTime dateTime);
    }

    public interface ICaliStore : IStore { }
}
