//Good article on DI
//http://visualstudiomagazine.com/articles/2014/05/01/how-to-refactor-for-dependency-injection.aspx?utm_source=dlvr.it&utm_medium=twitter

//try this for binding <Montana>
//http://stefanoricciardi.com/2011/01/21/ninject-mini-tutorial-part-1/

//use this to bind to Cali & MT stores
//http://www.codeproject.com/Tips/678129/No-more-factories-in-Csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Factory;


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



            #region IStore v1 implementation
            ////Change to a factory
            ////http://stackoverflow.com/questions/13057142/parameterized-factories-using-ninject

            //Store.IMTStore MTStore =kernel.Get<Store.IMTStore>();

            //FormHandler formHandler = new FormHandler( mailSender, lookupContext, MTStore );
            //formHandler.Handle( "me@test.com" );

            //Console.WriteLine();
            //Store.ICaliStore CAStore = kernel.Get<Store.ICaliStore>();
            //formHandler = new FormHandler(mailSender, lookupContext, CAStore);
            //formHandler.Handle("CA@storeTest.com");
            #endregion

            #region IStore v2 using Factory pattern
            //kernel.Bind<Store.IStoreFactory>().ToFactory();
            //var storeFactory = kernel.Get<Store.IStoreFactory>();

            //var mtStore = storeFactory.Create<Store.Montana>("MT");
            //FormHandler formHandler = new FormHandler(mailSender, lookupContext, mtStore);
            //formHandler.Handle("me@test.com");

            //var caliStore = storeFactory.Create<Store.California>("CA");
            //formHandler = new FormHandler(mailSender, lookupContext, caliStore);
            //formHandler.Handle("me2@test.com");

            #endregion

            #region IStore v3 IStore objects bound by Name
            
            string valueReadFromDB = Store.Stores.MT;
            var mt = kernel.Get<Store.IStore>(valueReadFromDB);
            Console.WriteLine(string.Format("{0} - {1}",mt.StoreId,mt.Name));
            FormHandler formHandler = new FormHandler( mailSender, lookupContext, mt );
            formHandler.Handle("me@test.com");

            //TODO #3 get the bound object from the kernel & use it
            var ca = kernel.Get<Store.IStore>(Store.Stores.CA);
            Console.WriteLine(string.Format("{0} - {1}", ca.StoreId, ca.Name));

            #endregion
        }
    }
    
}
