using System;
using System.ComponentModel;
using ServiceStack.DataAnnotations;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain
{
    [FluentValidation.Attributes.Validator(typeof(UserBillingInfoValidator))]
    [Serializable]
    public class UserBillingInfo : EntityBase
    {
        [AutoIncrement] // Creates Auto primary key
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Address1")]
        public string Address1 { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
          
        public UserBillingInfo (){}

        public UserBillingInfo(string firstName, string lastName,string middleName,
            string state, string address,string address1,string phone,string zipcode,string city)
        {
            FirstName  = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Address = address;
            Address1 = address1;
            State = state;
            PhoneNumber = phone;
            City = city;
            ZipCode = zipcode;

        }
    }

    #region UserBillingInfo Validation

    public class UserBillingInfoValidator : AbstractValidator<UserBillingInfo >
    {
        public UserBillingInfoValidator()
        {
            
            RuleFor(x => x.FirstName).NotEmpty().Length(2, 10).WithMessage("First Name is required");
            RuleFor(x => x.LastName ).NotEmpty().Length(2, 10).WithMessage("Last Name is required");
            RuleFor(x => x.EmailAddress).NotEmpty().Length(2, 10).WithMessage("Email Address is required");
            RuleFor(x => x.ZipCode).NotEmpty().Length(2, 10).WithMessage("Zip Code  is required");
            RuleFor(x => x.PhoneNumber).NotEmpty().Length(2, 10).WithMessage("Phone is required");
            RuleFor(x => x.Address).NotEmpty().Length(2, 10).WithMessage("Address is required");
            RuleFor(x => x.Address1).Length(0, 10).WithMessage("Address1 is required");
            RuleFor(x => x.City).NotEmpty().Length(2, 10).WithMessage("City is required");
            RuleFor(x => x.State).NotEmpty().Length(2, 10).WithMessage("State Selection is required");
         }
    }
    #endregion
}
