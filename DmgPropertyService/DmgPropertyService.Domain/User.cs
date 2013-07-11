using System;
using System.ComponentModel;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain
{
    [FluentValidation.Attributes.Validator(typeof(UserValidator))]

    [Serializable]
    public class User : EntityBase
    {
        [DisplayName("User Name")]
        public string UserName { get; set; }
        private string Password { get; set; }

        public User (){}

        public User(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
        public class UserValidator : AbstractValidator<User>
        {
            public UserValidator()
            {
                 
                RuleFor(x => x.UserName).NotEmpty() .Length(2, 10).WithMessage( "UseName is required");
                RuleFor(x => x.Password).Length(2, 10);
               
            }
        }


    }
}
