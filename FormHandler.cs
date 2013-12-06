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
        public FormHandler(IMailSender mailSender, IStateService lookups)
        {
            _mailSender = mailSender;
            _lookupContext = lookups;
        }

        public void Handle(string toAddress)
        {
            _mailSender.Send( toAddress, "This is non-Ninject example" );
            var states = _lookupContext.States();

            Console.WriteLine("States - " + states.Count());
            Console.WriteLine( _lookupContext.ToString() );
        }
    }
}
