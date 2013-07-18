using IN.DOT.DamagedProperty.Api.Domain.Model;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.WebUI.Models
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