using System;
using System.ComponentModel;
using ServiceStack.DataAnnotations;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    [FluentValidation.Attributes.Validator(typeof(UserBillingInfoValidator))]
    [Serializable]
    public class BillingInfo : EntityBase
    {
     
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


        public Address Address { get; set; }


       
          
        public BillingInfo (){}

        public BillingInfo(string firstName, string lastName,string middleName, string phone,string email)
        {
            FirstName  = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phone;
            EmailAddress = email;


        }
    }


  

  
}
