using System.ComponentModel;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    public class Address
    {

        [DisplayName("AddressLine1")]
        public string AddressLine1 { get; set; }

        [DisplayName("AddressLine2")]
        public string AddressLine2 { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }

        public Address() { }
        public Address(string state, string address1, string address2, string zipcode, string city)
        {
            AddressLine1 = address1;
            AddressLine2 = address2;
            City = city;
            State = state;
            ZipCode = zipcode;
        }


    }


    #region Address Validation
    public class AddressValidator : AbstractValidator<Address>
    {

        public AddressValidator()
        {
            RuleFor(x => x.AddressLine1).NotEmpty().Length(2, 10).WithMessage("Address is required");
            RuleFor(x => x.AddressLine2).Length(0, 10).WithMessage("Address1 is required");
            RuleFor(x => x.City).NotEmpty().Length(2, 10).WithMessage("City is required");
            RuleFor(x => x.State).NotEmpty().Length(2, 10).WithMessage("State Selection is required");
            RuleFor(x => x.ZipCode).NotEmpty().Length(2, 10).WithMessage("Zip Code  is required");
        }

    }
    #endregion
}
