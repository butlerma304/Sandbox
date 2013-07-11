using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmgPropertyService.Domain
{
    [Serializable]
    public class User : EntityBase
    {
        private string UserName { get; set; }
        private string Password { get; set; }

        public User (){}
        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }


    }
}
