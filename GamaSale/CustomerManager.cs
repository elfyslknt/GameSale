using System;
using System.Collections.Generic;
using System.Text;

namespace GamaSale
{
    class CustomerManager
    {
        public void Add(Customer customer,CheckManager checkManager)
        {
            checkManager.Check(customer);
            Console.WriteLine(customer.FirstName+" eklendi.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " güncelledi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " silindi.");
        }
    }
}
