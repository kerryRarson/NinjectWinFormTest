using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest.Store
{
    public class StoreReporter
    {
        private readonly IStore _store;
        public StoreReporter(IStore store)
        {
            _store = store;
        }
        public IStore Store { get { return _store; } }
    }
}
