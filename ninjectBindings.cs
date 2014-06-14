using Ninject.Modules;
using Ninject;
namespace ninjectTest
{
    public class ninjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
            Bind<IStateService>().To<StateService>();

            #region IStore v1
            ////bind stores
            //Bind<Store.IMTStore>().To<Store.Montana>();
            //Bind<Store.ICaliStore>().To<Store.California>();
            #endregion

            #region IStore v3 bind to IStore based on name

            //TODO #2 bind the new task name to the concrete implementation
            Bind<Store.IStore>().To<Store.Montana>().Named(Store.Stores.MT);
            Bind<Store.IStore>().To<Store.California>().Named(Store.Stores.CA);

            #endregion

        }
    }
}
