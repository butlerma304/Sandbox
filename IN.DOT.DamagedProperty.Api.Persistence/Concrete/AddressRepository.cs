using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Concrete;
using IN.DOT.DamagedProperty.Api.Persistence.Interface;

namespace IN.DOT.DamagedProperty.Api.Persistence.Concrete
{
  public class AddressRepository:BaseRepository<Address > 

  {
      private readonly IList<Address> _addressList;
         public AddressRepository()
        {
            _addressList = new List<Address>();
             _addressList.Add(new Address())
            {

                ID =  Guid("90C41BC8-32A5-4055-BF48-0B41DD313232"),
                     AddressLine1 = "10114 Washington";
            };
            _addressList.Add(new Address()
            {
                ID = [Guid("659475B4-1F45-4D48-BAF4-AD947455F0E1")],
                Name = "Widget2"
            });
        }

      #region " Methods "

      public Address Create(Address entity)
      {
          throw new NotImplementedException();
      }

      public void Delete(int id)
      {
          throw new NotImplementedException();
      }

      public IList<Address> Get()
      {
          return _addressList;
      }

      public IList<Address> Get(Func<Address, bool> predicate)
      {
          throw new NotImplementedException();
      }

      public Address Update(int id, Address entity)
      {
          throw new NotImplementedException();
      }

      #endregion

    }
}
