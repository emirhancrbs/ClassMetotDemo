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
        public void UpdateCustomer(int customerId, List<Customer> customers)
        {
            ListCustomer(customers);
            Console.Write("Güncellemek istediğiniz kullanıcının id sini giriniz = ");
            int _custonmerId;
            _custonmerId=Convert.ToInt32(Console.ReadLine());
            foreach (var customer in customers)
            {
                if (_custonmerId==customer.Id)
                {
                    Console.WriteLine(customer.Name);
                }
            }


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
