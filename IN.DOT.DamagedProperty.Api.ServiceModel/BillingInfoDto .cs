using System;
using System.Collections.Generic;
using IN.DOT.DamagedProperty.Api.Domain.Model;
using IN.DOT.DamagedProperty.Api.Persistence.Abstract;
using ServiceStack.DataAnnotations;

namespace IN.DOT.DamagedProperty.Api.ServiceModel
{
    public enum PhoneType
    {
        Home,
        Work,
        Mobile,
    }

    public enum AddressType
    {
        Home,
        Work,
        Other,
    }
    public class BillingInfo:DtoBase
    {
        //  [AutoIncrement] // Creates Auto primary key
        public Guid ID { get; set; }

        [References(typeof(User))]      //Creates Foreign Key
        public Guid? UserID { get; set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }


        public Dictionary<PhoneType, string> PhoneNumbers { get; set; }

        public Dictionary<AddressType, Address> Addresses { get; set; }  
   
        public BillingInfo()
        {
            ID = GuidNullValue;
            UserID = GuidNullValue;
            FirstName  = StringNullValue;
            MiddleName = StringNullValue;
            LastName = StringNullValue;
        
            PhoneNumbers = new Dictionary<PhoneType, string>();
            Addresses = new Dictionary<AddressType, Address>();
        }
    }
}
