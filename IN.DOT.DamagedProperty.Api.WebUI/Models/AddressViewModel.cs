using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace IN.DOT.DamagedProperty.WebUI.Models
{
    public class AddressViewModel
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

            public AddressViewModel() { }
            public AddressViewModel(string state, string address1, string address2, string zipcode, string city)
            {
                AddressLine1 = address1;
                AddressLine2 = address2;
                City = city;
                State = state;
                ZipCode = zipcode;
            }


        

    }
}