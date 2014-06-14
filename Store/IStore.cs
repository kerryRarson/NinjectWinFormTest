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

    //TODO #1  Add the new tasks name so ninject knows what to bind to
    public static class Stores
    {
        public const string MT  = "MT";
        public const string CA = "CA";
        public const string WY = "WY";
    }
    //from v2
    //public interface IStoreFactory
    //{
    //    T Create<T>(string name) where T : IStore;
    //}

}
