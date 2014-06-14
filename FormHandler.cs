using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest
{
    public class FormHandler
    {
        private readonly IMailSender _mailSender;
        private readonly IStateService _lookupContext;
        private readonly Store.IStore _store;
        public FormHandler(IMailSender mailSender, IStateService lookups, Store.IStore store)
        {
            _mailSender = mailSender;
            _lookupContext = lookups;
            _store = store;
        }

        public void Handle(string toAddress)
        {
            _mailSender.Send( toAddress, "This is a Ninject DI example" );
            var states = _lookupContext.States();

            Console.WriteLine("States - " + states.Count());
            Console.WriteLine( _lookupContext.ToString() );

            Console.WriteLine();
            Console.WriteLine(string.Format("using store '{0}'", _store.Name));
            Console.WriteLine("Is the store open? - " + _store.IsStoreOpen(DateTime.Now));
            Console.WriteLine("Is the store open on Sunday? - " + _store.IsStoreOpen(DateTime.Parse("5/4/2014")));
        }
    }
}
