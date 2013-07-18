using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Abstract;
using IN.DOT.DamagedProperty.Api.Persistence.Interface;
using IN.DOT.DamagedProperty.Api.ServiceModel.Exchange;
using ServiceStack.ServiceInterface;

namespace IN.DOT.DamagedProperty.Api.ServiceInterface
{
    public class WidgetService : Service
    {

        private readonly IRepository<Widget> _repository;

        public WidgetService(IRepository<Widget> repository)
        {
            _repository = repository;
        }

        #region " Methods "


        public AllWidgetsResponse Get(AllWidgets request)
        {
            var response = new AllWidgetsResponse()
            {
                Results = _repository.Get().ToList()
            };

            return response;
        }

        #endregion
    }
}