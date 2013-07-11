using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DmgPropertyService.Domain;
using ServiceStack.FluentValidation;

namespace DmgPropertyService.Web.Models
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