using System.ComponentModel;
using ServiceStack.FluentValidation;

namespace IN.DOT.DamagedProperty.Api.Domain.Model
{
    public class Address
    {

        
        public string AddressLine1 { get; set; }

     
        public string AddressLine2 { get; set; }

      
        public string City { get; set; }

       
        public string State { get; set; }

      
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


    
}
