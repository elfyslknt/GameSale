using System;

namespace GamaSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {CustomerId=1,TcNo="11111231112",FirstName="Bahar" ,LastName="Yagmur"};
            Customer customer2 = new Customer { CustomerId = 2, TcNo = "88111231112", FirstName = "Gunes", LastName = "Işık" };
            Customer customer3 = new Customer { CustomerId = 3, TcNo = "88111234882", FirstName = "Ruzgar", LastName = "Ugul" };

            CustomerManager customerManager = new CustomerManager();
            CheckManager checkManager = new CheckManager();

            customerManager.Add(customer1,checkManager);
            customerManager.Delete(customer2);
            customerManager.Update(customer3);

            ICampaignManager newYearManager = new NewYearManager();
            ICampaignManager springManager = new SpringManager();

            SalesManager salesManager = new SalesManager();

            salesManager.Sales(customer1, newYearManager);
            salesManager.Sales(customer3, springManager);

        }
    }
}
