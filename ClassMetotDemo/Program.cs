// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

CustomerManager customerManager= new CustomerManager();

Customer customer=new Customer();

customer.Id = 1;
customer.Name = "Emirhan";
customer.Surname = "Çeribaş";
customer.Email = "emirhan@gmail.com";
customer.PhoneNumber = "0(555) 555 55 55";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Yagmur";
customer2.Surname = "Türkköylü";
customer2.Email = "ygmr@gmail.com";
customer2.PhoneNumber = "0(555) 555 55 55";

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.Name = "Barış";
customer3.Surname = "Türkköylü";
customer3.Email = "baris@gmail.com";
customer3.PhoneNumber = "0(555) 555 55 55";

List<Customer> customers = new List<Customer>();
customers.Add(customer);
customers.Add(customer2);
customers.Add(customer3);

Console.WriteLine("-------------------------------");
Console.WriteLine("1-Müşteri Ekleme");
Console.WriteLine("2-Müşteri Silme");
Console.WriteLine("3-Müşteri Listeleme");
Console.WriteLine("4-Müşteri Güncelleme");
Console.Write("Lütfen Yapmak istediğiniz İşlemi Seçiniz = ");
int process = Convert.ToInt32(Console.ReadLine());

int customersLengt = customers.Count();
Customer customer4 = new Customer();


do
{

} while (true);
switch(process)
{
    case 1:
        customer4.Id = customersLengt + 1;
        Console.Write("Müşteri Adını Giriniz = ");
        customer4.Name = Console.ReadLine();
        Console.Write("Müşteri  Soyadını Giriniz = ");
        customer4.Surname = Console.ReadLine();
        Console.Write("Müşteri  E-mail Giriniz = ");
        customer4.Email = Console.ReadLine();
        Console.Write("Müşteri  Telefon Numarasını Giriniz = ");
        customer4.Email = Console.ReadLine();
        customerManager.AddCustomer(customer4, customers);
        break;
    case 2:
        customerManager.ListCustomer(customers);
        Console.Write("Silinecek Müşterinin Id sini giriniz = ");
        int customerId = Convert.ToInt32(Console.ReadLine());
        customerManager.DeleteCustomer(customerId,customers );
        break;
    default:
        Console.WriteLine("Lütfen bir işlem seçiniz.");
        break;
}
