﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Funq;
using IN.DOT.DamagedProperty.Api.Services.Infrastructure.Security;

namespace IN.DOT.DamagedProperty.Api.WebUI.Infrastructure.Container
{
    internal class ServicesModule
    {
        internal static void Configure(Funq.Container container)
        {
            container.RegisterAutoWiredAs<WebSecurityService, ISecurityService>()
                .ReusedWithin(ReuseScope.Hierarchy);
        }
    }
}