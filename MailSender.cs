using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninjectTest
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
    public class MailSender : IMailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine( "Sending mail to [{0}] with subject [{1}]", toAddress, subject );
        }
    }
}
