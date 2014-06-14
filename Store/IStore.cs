using System;
using System.Linq;

namespace ninjectTest.Store
{
    public interface IStore
    {
        long StoreId { get; }
        string Name { get; }
        bool IsStoreOpen(DateTime dateTime);
    }

    public interface IMTStore : IStore { }
    public interface ICaliStore : IStore { }

    public interface IStoreFactory
    {
        T Create<T>(string name) where T : IStore;
    }
}
