using System;
using System.Collections;
using System.Data;
using System.Text;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;


namespace DmgPropertyService.Domain
{
    [Route("/customers")]
    [Route("/customers/{ID}")]
    public class Customer
    {
        [AutoIncrement] //OrmLite Hint
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceDate { get; set; }

        public Customer() {}

        public Customer(string custNumber, string invNumber, string invType, string invDate)
        {
            CustomerNumber = custNumber;
            InvoiceNumber = invNumber;
            InvoiceType = invType;
            InvoiceDate = invDate;

        }
    }

    public class CustomerList : IEnumerable
    {
        private readonly Customer[] _customer;

        public CustomerList(Customer[] cArray)
        {

            _customer = new Customer[cArray.Length];

            for (var i = 0; i < cArray.Length; i++)
            {
                _customer[i] = cArray[i];
            }

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CustomersEnum GetEnumerator()
        {
            return new CustomersEnum(_customer);
        }

    }

    public class CustomersEnum : IEnumerator
    {
        public Customer[] Customer;

        // Enumerators are positioned before the first element 
        // until the first MoveNext() call. 
        int _position = -1;

        public CustomersEnum(Customer[] list)
        {
            Customer = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < Customer.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Customer Current
        {
            get
            {
                try
                {
                    return Customer[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


    public class CustomerService:RestServiceBase<Customer>
    {
        public IDbConnection DbFactory { get; set; }
        public override object OnGet(Customer request)
        {
            if (request.Id != default(int))
                return DbFactory.Exec(dbCmd => dbCmd.GetById<Customer>(request.Id));
            return DbFactory .Exec( dbCmd => dbCmd.Select<Customer>());
        }



    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var customersArray = new Customer[3]
    //        {
    //            new Customer("023541", "GC2133", "type001","7/3/2013"  ),
    //            new Customer("185627", "QR3456", "type003","7/3/2013"),
    //            new Customer("314567", "QX5678", "type004","7/3/2013"),
    //        };

    //        var sb = new StringBuilder();
    //        var customersList = new Customers(customersArray);
    //        foreach (var c in customersList)
    //        {

    //            sb.AppendFormat("{0,-8}{1,-20}{2,-10}{3,-10:yyyyMMdd}{4}",
    //                                          c.CustomerNumber.ToString().PadLeft(6, '0'),
    //                                          c.InvoiceNumber,
    //                                          c.InvoiceType,
    //                                          c.InvoiceDate,
    //                                          Environment.NewLine);
    //            Console.WriteLine(c.CustomerNumber + " " + c.InvoiceNumber + " " + c.InvoiceDate);

    //        }

    //    }
    //}
}



