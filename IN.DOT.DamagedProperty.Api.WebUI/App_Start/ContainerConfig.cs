using IN.DOT.DamagedProperty.WebUI.Infrastructure.Container;
using ServiceStack.CacheAccess;
using ServiceStack.CacheAccess.Providers;

namespace IN.DOT.DamagedProperty.Api.WebUI
{
    public class ContainerConfig
    {
        /// <summary>
        /// Configures the dependency injection container used by ServiceStack.
        /// </summary>
        /// <param name="container"></param>
        internal static void ConfigureContainer(Funq.Container container)
        {
            // Register storage for user sessions 
            container.Register<ICacheClient>(new MemoryCacheClient());

            PersistenceModule.Configure(container);
            ServicesModule.Configure(container);
            ValidationModule.Configure(container);
        }
    }
}