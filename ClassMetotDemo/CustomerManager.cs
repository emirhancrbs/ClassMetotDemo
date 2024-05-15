using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer ,List<Customer> customers)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name+"Başarıyla Eklendi");
        }
        public void DeleteCustomer(Customer customer,List<Customer> customers)
        {

        }
    }
}
