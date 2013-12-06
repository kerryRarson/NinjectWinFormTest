using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ninjectTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //taken from http://www.christiaanverwijs.nl/post/2012/07/28/A-step-by-step-guide-to-using-Ninject-for-dependancy-injection-in-C-sharp.aspx

            //non DI example
            //IMailSender mailSender = new MailSender();
            //mailSender.Send( "kelley.larsen@torrentcorp.com", "This is still a non-Ninject example" );

            ////non-ninject DI example
            //IMailSender mailSender = new MailSender();
            //FormHandler formHandler = new FormHandler( mailSender );
            //formHandler.Handle( "test@test.com" );

            //Console.ReadLine();    

            //ninject DI example
            IKernel kernel = new StandardKernel();
            kernel.Load( Assembly.GetExecutingAssembly() );
            IMailSender mailSender = kernel.Get<IMailSender>();
            IStateService lookupContext = kernel.Get<IStateService>();

            FormHandler formHandler = new FormHandler( mailSender, lookupContext );
            formHandler.Handle( "me@test.com" );

            Console.ReadLine();
        }
    }
}
