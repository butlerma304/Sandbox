using System;
using System.ComponentModel;
using ServiceStack.DataAnnotations;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain
{
    [FluentValidation.Attributes.Validator(typeof(UserValidator))]

    [Serializable]
    public class User : EntityBase
    {
        [AutoIncrement] // Creates Auto primary key
        public int Id { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }
        public  string Password { get; set; }
        
        public User (){}

        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
    }
    #region User Validation

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName ).NotEmpty().Length(2, 10).WithMessage("UserName is required");
            RuleFor(x => x.Password ).NotEmpty().Length(2, 10).WithMessage("Password is required");
         }
    }
    #endregion
}


