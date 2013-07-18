﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace IN.DOT.DamagedProperty.Api.ServiceModel.Exchange
{
    [Authenticate]
    public class AllWidgets : IReturn<AllWidgetsResponse>
    {
    }
}