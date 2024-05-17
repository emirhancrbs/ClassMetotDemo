using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public void DeleteCustomer(int CustomeId,List<Customer> customers)
        {
            customers.RemoveAt(CustomeId-1);
            Console.WriteLine("Müşteri başarıyla silindi.");
        }
        public void ListCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id = "+ customer.Id+"\nName = "+ customer.Name+"\nSurname = "+ customer.Surname+"\nPhone Number = "+ customer.PhoneNumber+"E-mail = "+ customer.Email+"\n-----------------------------------------------------");
            }
        }
    }
}
