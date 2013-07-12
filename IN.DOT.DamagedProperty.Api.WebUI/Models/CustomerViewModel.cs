namespace IN.DOT.DamagedProperty.Api.WebUI.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceDate { get; set; }
    }

    // private Customer GetCustomerFromDB()
    //{
    //    return new Customer()
    //    {
    //        DateOfBirth = new DateTime(1987, 11, 2),
    //        FirstName = "Andriy",
    //        LastName = "Buday",
    //        NumberOfOrders = 7
    //    };
    //}
    }


