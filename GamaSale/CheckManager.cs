using System;
using System.Collections.Generic;
using System.Text;

namespace GamaSale
{
    class CheckManager
    {
        public void Check(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" kişi onaylandı");
        }
    }
}
