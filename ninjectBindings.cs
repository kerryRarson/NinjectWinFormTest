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

            //bind stores
            Bind<Store.IMTStore>().To<Store.Montana>();
            Bind<Store.ICaliStore>().To<Store.California>();

        }
    }
}
