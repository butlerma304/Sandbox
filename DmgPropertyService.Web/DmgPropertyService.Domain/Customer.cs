using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Customer
    {
        public string customerNumber;
        public string invoiceNumber;
        public string invoiceType;
        public string invoiceDate;

        public Customer(string custNumber, string invNumber, string invType, string invDate)
        {
            customerNumber = custNumber;
            invoiceNumber = invNumber;
            invoiceType = invType;
            invoiceDate = invDate;

        }
    }

    public class Customers : IEnumerable
    {
        private Customer[] _customer;

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
        public Customer[] _customer;

        // Enumerators are positioned before the first element 
        // until the first MoveNext() call. 
        int position = -1;

        public CustomersEnum(Customer[] list)
        {
            _customer = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _customer.Length);
        }

        public void Reset()
        {
            position = -1;
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
                    return _customer[position];
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
            Customer[] customersArray = new Customer[3]
            {
                new Customer("023541", "GC2133", "type001","7/3/2013"  ),
                new Customer("185627", "QR3456", "type003","7/3/2013"),
                new Customer("314567", "QX5678", "type004","7/3/2013"),
            };

            StringBuilder sb = new StringBuilder();
            Customers customersList = new Customers(customersArray);
            foreach (Customer c in customersList)
            {

                sb.AppendFormat("{0,-8}{1,-20}{2,-10}{3,-10:yyyyMMdd}{4}",
                                              c.customerNumber.ToString().PadLeft(6, '0'),
                                              c.invoiceNumber,
                                              c.invoiceType,
                                              c.invoiceDate,
                                              Environment.NewLine);
                Console.WriteLine(c.customerNumber + " " + c.invoiceNumber + " " + c.invoiceDate);

            }

        }
    }
}



