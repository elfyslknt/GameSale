using System;
using System.Collections.Generic;
using System.Text;

namespace GamaSale
{
    class SalesManager
    {
        public void Sales(Customer customer,ICampaignManager campaignManager)
        {
            Console.Write(customer.FirstName+" "+customer.LastName+" adlı oyuncuya ");
            campaignManager.CalculateCampaign();
        }
    }
}
