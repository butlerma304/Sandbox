using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.WebUI.Validators;

namespace IN.DOT.DamagedProperty.WebUI.Models
{

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    [FluentValidation.Attributes.Validator(typeof(UserBillingInfoValidator))]
    [Serializable]
    public class BillingInfo : EntityBase
    {
      //  [AutoIncrement] // Creates Auto primary key
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


       
         
       
    }


    }
}