using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Interface;

namespace IN.DOT.DamagedProperty.Api.Persistence.Concrete
{
    public class BillingInfoRepository:BaseRepository<BillingInfoRepository>
    {
        private readonly IList<BillingInfo> _billingInfoList;

           public BillingInfoRepository()
        {
            _billingInfoList = new List<BillingInfo>();

            _billingInfoList.Add(new BillingInfo( )
            {
                ID = 1,
                FirstName  = "Timothy",
                LastName   = "Roussel"
            });

            _billingInfoList.Add(new BillingInfo()
            {
                ID = 1,
                FirstName = "Charles",
                LastName = "Diamond"
            });
        }
        #region " Methods "

        public BillingInfo Create(BillingInfo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BillingInfo> Get()
        {
            return _billingInfoList;
        }

        public IList<BillingInfo> Get(Func<BillingInfo, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public BillingInfo Update(int id, BillingInfo entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
