using Funq;
using IN.DOT.DamagedProperty.Api.Services.Security;

namespace IN.DOT.DamagedProperty.WebUI.Infrastructure.Container 
{
    internal class ServicesModule
    {
       /// <summary>
       /// ReUsescope Hierarchy: Instances are reused only at the given container. Descendent 
       /// containers do not reuse parent container instances and get  
       /// a new instance at their level.
       /// </summary>
       /// <param name="container"></param>
        internal static void Configure(Funq.Container container)
        {
            container.RegisterAutoWiredAs<WebSecurityService, ISecurityService>()
                .ReusedWithin(ReuseScope.Hierarchy);
        }
    }
}