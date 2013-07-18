using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using ServiceStack.ServiceInterface.ServiceModel;

namespace IN.DOT.DamagedProperty.Api.ServiceModel.Exchange
{
    public class AllWidgetsResponse
    {

        public IList<Widget> Results { get; set; }

        public ResponseStatus ResponseStatus { get; set; }

    }
}