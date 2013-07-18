using System;
using System.ComponentModel;
using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
   // [FluentValidation.Attributes.Validator(typeof(UserValidator))]

    [Serializable]
    public class User : EntityBase  , IHasId<Guid>
    {
         
       // [AutoIncrement] // Creates Auto primary key
     //   public Guid ID { get; set; }
        public string UserName { get; set; }
        public  string Password { get; set; }
        public string PasswortdHash { get; set; }
        public string Email { get; set; }
        public Guid ID
        {
            get { return Guid.NewGuid(); }
        }  
        public User (){}

        public User(string userName,string password, string email,string passwordHash,bool IsActive )
        {
            UserName = userName;
            Password = password;
            passwordHash = passwordHash;
            Email = email;
        }
    }
  
}


