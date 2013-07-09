using System;
using System.Collections;
using System.Text;
using ServiceStack.DataAnnotations;


namespace DmgPropertyService.Domain
{
    public class Customer
    {
        [AutoIncrement] //OrmLite Hint
        public string CustomerNumber;
        public string InvoiceNumber;
        public string InvoiceType;
        public string InvoiceDate;

        public Customer() {}

        public Customer(string custNumber, string invNumber, string invType, string invDate)
        {
            CustomerNumber = custNumber;
            InvoiceNumber = invNumber;
            InvoiceType = invType;
            InvoiceDate = invDate;

        }
    }

    public class Customers : IEnumerable
    {
        private readonly Customer[] _customer;

        public Customers(Customer[] cArray)
        {

            _customer = new Customer[cArray.Length];

            for (int i = 0; i < cArray.Length; i++)
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

    class Program
    {
        static void Main(string[] args)
        {
            var customersArray = new Customer[3]
            {
                new Customer("023541", "GC2133", "type001","7/3/2013"  ),
                new Customer("185627", "QR3456", "type003","7/3/2013"),
                new Customer("314567", "QX5678", "type004","7/3/2013"),
            };

            var sb = new StringBuilder();
            var customersList = new Customers(customersArray);
            foreach (var c in customersList)
            {

                sb.AppendFormat("{0,-8}{1,-20}{2,-10}{3,-10:yyyyMMdd}{4}",
                                              c.CustomerNumber.ToString().PadLeft(6, '0'),
                                              c.InvoiceNumber,
                                              c.InvoiceType,
                                              c.InvoiceDate,
                                              Environment.NewLine);
                Console.WriteLine(c.CustomerNumber + " " + c.InvoiceNumber + " " + c.InvoiceDate);

            }

        }
    }
}



