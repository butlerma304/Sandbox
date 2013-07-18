using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IN.DOT.DamagedProperty.Api.Domain.Model;

namespace IN.DOT.DamagedProperty.Api.Persistence.Concrete
{
 public  class UserRepository:BaseRepository< User>
  {
      private readonly IList<User> _userList;
       
      public UserRepository()
        {
            _userList = new List<User >
                {
                    new User()
                        {
                            ID = 1,
                            UserName  = "Jane"
                        },
                    new User()
                        {
                            ID = 2,
                            UserName  = "Fred"
                        }
                };
        }
      #region " Methods "

      public User Create(User entity)
      {
          throw new NotImplementedException();
      }

      public void Delete(int id)
      {
          throw new NotImplementedException();
      }

      public IList<User> Get()
      {
          return _userList;
      }

      public IList<User> Get(Func<User, bool> predicate)
      {
          throw new NotImplementedException();
      }

      public User Update(int id, User entity)
      {
          throw new NotImplementedException();
      }

      #endregion
    }
}
