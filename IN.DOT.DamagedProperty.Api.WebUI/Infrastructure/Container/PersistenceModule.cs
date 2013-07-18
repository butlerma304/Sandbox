using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Concrete;
using IN.DOT.DamagedProperty.Api.Persistence.Interface;

namespace IN.DOT.DamagedProperty.WebUI.Infrastructure.Container
{
    internal class PersistenceModule
    {
        internal static void Configure(Funq.Container container)
        {
            // Register any dependencies your services use, e.g:
            // container.Register<ICacheClient>(new MemoryCacheClient());
            container.Register<IRepository<Widget>>(c => new FakeWidgetRepository());
            container.Register<IRepository<User>>(c => new UserRepository());
            container.Register<IRepository<User>>(c => new BillingInfoRepository());
            container.Register<IRepository<User>>(c => new AddressRepository());
        }
    }
}