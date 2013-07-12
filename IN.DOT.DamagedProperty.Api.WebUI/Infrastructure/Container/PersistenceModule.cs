﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Abstract;
using IN.DOT.DamagedProperty.Api.Persistence.Concrete;

namespace IN.DOT.DamagedProperty.Api.WebUI.Infrastructure.Container
{
    internal class PersistenceModule
    {
        internal static void Configure(Funq.Container container)
        {
            // Register any dependencies your services use, e.g:
            // container.Register<ICacheClient>(new MemoryCacheClient());
            container.Register<IRepository<Widget>>(c => new FakeWidgetRepository());
        }
    }
}