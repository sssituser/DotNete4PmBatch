using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    class Customer
    {
        private int customerId;
        private string customerNae;
        private string customerContact;

        public string CustomerContact
        {
            get { return customerContact; }
            set { customerContact = value; }
        }

        public string CustomerName
        {
            get { return customerNae; }
            set { customerNae = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

    }

    internal class Class6
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 111;
            customer.CustomerName = "kumar";
            customer.CustomerContact = "999999999";

            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerContact);

        }
    }
}

