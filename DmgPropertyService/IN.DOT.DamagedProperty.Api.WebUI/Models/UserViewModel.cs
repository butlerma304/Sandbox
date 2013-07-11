using IN.DOT.DamagedProperty.Api.Domain;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.WebUI.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().Length(2, 10).WithMessage("UserName is required");
            RuleFor(x => x.UserName).NotEmpty().Length(2, 10).WithMessage("Password is required");
        }
     }
}